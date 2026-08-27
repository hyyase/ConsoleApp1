public class HelpDesks : Funcionario
{
    public HelpDesks(string nome, string matricula)
        : base(nome, matricula, Cargo.HelpDesks, Aparelhos.Desktop)
    {
    }

    public void PrestarSuporte()
    {
        Console.WriteLine($"{Nome} está prestando suporte técnico.");
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
