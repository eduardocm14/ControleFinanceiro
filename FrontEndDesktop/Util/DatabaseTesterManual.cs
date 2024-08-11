using Npgsql;
using System;

public class DatabaseTesterManual
{
    private readonly string _connectionString;

    public DatabaseTesterManual(string connectionString)
    {
        _connectionString = connectionString;
    }

    public bool TestarConexao()
    {
        try
        {
            using (var connection = new NpgsqlConnection(_connectionString))
            {
                connection.Open();
                // Se a conexão abrir com sucesso, retorne verdadeiro
                return true;
            }
        }
        catch (Exception ex)
        {
            // Se ocorrer uma exceção, exiba a mensagem de erro e retorne falso
            Console.WriteLine($"Erro ao conectar ao banco de dados: {ex.Message}");
            return false;
        }
    }
}
