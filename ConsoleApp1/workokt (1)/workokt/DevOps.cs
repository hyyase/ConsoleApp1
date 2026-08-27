public class DevOps : Funcionario
{
    public DevOps(string nome, string matricula)
        : base(nome, matricula, Cargo.DevOps, Aparelhos.Monitor)
    {
    }

    public void GerenciarInfraestrutura()
    {
        Console.WriteLine($"{Nome} está gerenciando a infraestrutura de TI.");
    }

    public override void ExibirInformacoes()
    {
        Console.WriteLine($"=== Perfil Público ===");
        Console.WriteLine($"Nome:      {Nome}");
        Console.WriteLine($"Matrícula: {Matricula}");
        Console.WriteLine($"Cargo:     {Cargo}");
        Console.WriteLine($"Aparelho:  {Aparelho}");
        Console.WriteLine($"=====================");
    }
}
