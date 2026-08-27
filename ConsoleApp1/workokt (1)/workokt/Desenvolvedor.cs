public class Desenvolvedor : Funcionario
{
    public string Linguagem { get; set; }

    public Desenvolvedor(string nome, string matricula, string linguagem)
        : base(nome, matricula, Cargo.Desenvolvedor, Aparelhos.Notebook)
    {
        Linguagem = linguagem;
    }

    public override void ExibirInformacoes()
    {
        Console.WriteLine($"=== Perfil Público ===");
        Console.WriteLine($"Nome:      {Nome}");
        Console.WriteLine($"Matrícula: {Matricula}");
        Console.WriteLine($"Cargo:     {Cargo}");
        Console.WriteLine($"Linguagem: {Linguagem}");
        Console.WriteLine($"Aparelho:  {Aparelho}");
        Console.WriteLine($"=====================");
    }

    public void AcessarRepo()
    {
        Console.WriteLine($"{Nome} acessou o repositório de código.");
    }
}
