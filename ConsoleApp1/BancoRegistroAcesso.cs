using Microsoft.Data.SqlClient;

public class BancoRegistroAcesso
{
    private readonly string _connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=workot;Integrated Security=true;";

    public void Inserir(int funcionarioId, string tipoEvento)
    {
        using var conn = new SqlConnection(_connectionString);
        conn.Open();

        var cmd = new SqlCommand(@"
            INSERT INTO RegistrosAcesso (FuncionarioId, TipoEvento, DataHora)
            VALUES (@FuncionarioId, @TipoEvento, @DataHora)", conn);

        cmd.Parameters.AddWithValue("@FuncionarioId", funcionarioId);
        cmd.Parameters.AddWithValue("@TipoEvento", tipoEvento);
        cmd.Parameters.AddWithValue("@DataHora", DateTime.Now);

        cmd.ExecuteNonQuery();
        Console.WriteLine($"Acesso '{tipoEvento}' registrado para funcionário ID {funcionarioId}.");
    }

    public void ListarHoje()
    {
        using var conn = new SqlConnection(_connectionString);
        conn.Open();

        var cmd = new SqlCommand(@"
            SELECT r.Id, f.Nome, r.TipoEvento, r.DataHora
            FROM RegistrosAcesso r
            INNER JOIN Funcionarios f ON f.Id = r.FuncionarioId
            WHERE CAST(r.DataHora AS DATE) = CAST(GETDATE() AS DATE)
            ORDER BY r.DataHora", conn);

        using var reader = cmd.ExecuteReader();

        Console.WriteLine("\n=== Acessos de Hoje ===");
        while (reader.Read())
        {
            Console.WriteLine($"[{reader["DataHora"]:HH:mm}] {reader["TipoEvento"]} — {reader["Nome"]}");
        }
    }
}