public class Analista : Funcionario
{
    public Analista(string nome, string matricula)
        : base(nome, matricula, Cargo.Analista, Aparelhos.Desktop)
    {
    }

    public void AnalisarDados()
    {
        Console.WriteLine($"{Nome} está analisando os dados.");
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
