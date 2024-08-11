using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using WindowsFormFinanceiro.Model;
using WindowsFormFinanceiro.Util;

public class ContaRepository
{
    private readonly AppDbContext contexto;

    public ContaRepository()
    {
        contexto = new AppDbContext();
    }

    public void AdicionarConta(Conta conta)
    {
        contexto.Contas.Add(conta);
        contexto.SaveChanges();
    }

    public void AtualizarConta(Conta conta)
    {
        contexto.Entry(conta).State = EntityState.Modified;
        contexto.SaveChanges();
    }

    public void ExcluirConta(int id)
    {
        var conta = contexto.Contas.Find(id);

        if (conta != null)
        {
            contexto.Contas.Remove(conta);
            contexto.SaveChanges();
        }
    }

    public Conta BuscarContaPorId(int id)
    {
        return contexto.Contas.Find(id);
    }

    public List<Conta> GetContasPorDatas(DateTime dataInicio, DateTime dataFim, int tipoConta, string descricaoConta)
    {
        try
        {
            if (tipoConta == Utilitario.TipoContas.ContasPagas.GetHashCode())
            {
                return contexto.Contas.AsNoTracking()
                                      .Where(c => c.DataVencimento >= dataInicio && c.DataVencimento <= dataFim && c.Pago && c.Nome.StartsWith(descricaoConta))
                                      .OrderBy(c => c.DataVencimento)
                                      .ToList();
            }
            else if (tipoConta == Utilitario.TipoContas.ContasPagar.GetHashCode())
            {
                return contexto.Contas.AsNoTracking()
                                      .Where(c => c.DataVencimento >= dataInicio && c.DataVencimento <= dataFim && !c.Pago && c.Nome.StartsWith(descricaoConta))
                                      .OrderBy(c => c.DataVencimento)
                                      .ToList();
            }
            else if (tipoConta == Utilitario.TipoContas.ContasVencidas.GetHashCode())
            {
                DateTime hoje = DateTime.Today;

                return contexto.Contas.AsNoTracking()
                                      .Where(c => c.DataVencimento < hoje && !c.Pago && c.Nome.StartsWith(descricaoConta))
                                      .OrderBy(c => c.DataVencimento)
                                      .ToList();
            }
            else
            { 
                return contexto.Contas.AsNoTracking()
                                      .Where(c => c.DataVencimento >= dataInicio && c.DataVencimento <= dataFim && c.Nome.StartsWith(descricaoConta))
                                      .OrderBy(c => c.DataVencimento)
                                      .ToList();
            }
        }
        catch (Exception ex)
        {
            // Log da exceção ou exibição da mensagem de erro
            throw new Exception("Erro ao obter contas por data", ex);
        }
    }

    public List<Conta> GetContasPorDataPagamento(DateTime dataInicio, DateTime dataFim)
    {
        try
        {
            return contexto.Contas.AsNoTracking()
                                  .Where(c => c.DataPagamento >= dataInicio && c.DataPagamento <= dataFim)
                                  .OrderBy(c => c.DataPagamento)
                                  .ToList();
        }
        catch (Exception ex)
        {
            // Log da exceção ou exibição da mensagem de erro
            throw new Exception("Erro ao obter contas por data", ex);
        }
    }
}
