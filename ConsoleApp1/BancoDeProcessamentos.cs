using Microsoft.Data.SqlClient;

public class BancoFuncionario
{
    private readonly string _connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=workot;Integrated Security=true;";

    public void Inserir(Funcionario funcionario)
    {
        using var conn = new SqlConnection(_connectionString);
        conn.Open();

        var cmd = new SqlCommand(@"
            INSERT INTO Funcionarios (Nome, Matricula, Cargo, Aparelho, Ativo)
            VALUES (@Nome, @Matricula, @Cargo, @Aparelho, @Ativo)", conn);

        cmd.Parameters.AddWithValue("@Nome", funcionario.Nome);
        cmd.Parameters.AddWithValue("@Matricula", funcionario.Matricula);
        cmd.Parameters.AddWithValue("@Cargo", funcionario.Cargo.ToString());
        cmd.Parameters.AddWithValue("@Aparelho", funcionario.Aparelho.ToString());
        cmd.Parameters.AddWithValue("@Ativo", funcionario.Ativo);

        cmd.ExecuteNonQuery();
        Console.WriteLine($"{funcionario.Nome} salvo no banco!");
    }

    public void ListarTodos()
    {
        using var conn = new SqlConnection(_connectionString);
        conn.Open();

        var cmd = new SqlCommand("SELECT Id, Nome, Matricula, Cargo, Aparelho, Ativo FROM Funcionarios", conn);
        using var reader = cmd.ExecuteReader();

        Console.WriteLine("\n=== Funcionários no Banco ===");
        while (reader.Read())
        {
            Console.WriteLine($"[{reader["Id"]}] {reader["Nome"]} | {reader["Cargo"]} | {reader["Matricula"]} | Ativo: {reader["Ativo"]}");
        }
    }
}