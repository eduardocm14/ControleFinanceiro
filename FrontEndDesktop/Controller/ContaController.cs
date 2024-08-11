using System;
using System.Collections.Generic;
using WindowsFormFinanceiro.Model;

public class ContaController
{
    private readonly ContaRepository repositorio;

    public ContaController()
    {
        repositorio = new ContaRepository();
    }

    //public List<Conta> CarregarContas()
    //{
    //    return repositorio.GetAll();
    //}

    public void AdicionarConta(Conta conta)
    {
        repositorio.AdicionarConta(conta);
    }

    public void AtualizarConta(Conta conta)
    {
        repositorio.AtualizarConta(conta);
    }

    public void ExcluirConta(int id)
    {
        repositorio.ExcluirConta(id);
    }

    public Conta BuscarContaPorId(int id)
    {
        return repositorio.BuscarContaPorId(id);
    }

    public List<Conta> GetContasPorDatas(DateTime dataInicio, DateTime dataFim, int tipoConta, string descricaoConta)
    {
        return repositorio.GetContasPorDatas(dataInicio, dataFim, tipoConta, descricaoConta);
    }

    public List<Conta> GetContasPorDataPagamento(DateTime dataInicio, DateTime dataFim)
    {
        return repositorio.GetContasPorDataPagamento(dataInicio, dataFim);
    }
}
