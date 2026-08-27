public abstract class Funcionario
{
    public string Nome { get; set; }
    public string Matricula { get; set; }
    public Cargo Cargo { get; set; }
    public Aparelhos Aparelho { get; set; }
    public bool Ativo { get; set; }



    public Funcionario(string nome, string matricula, Cargo cargo, Aparelhos aparelho, bool ativo = true)
    {
        Nome = nome;
        Matricula = matricula;
        Cargo = cargo;
        Aparelho = aparelho;
        Ativo = ativo;
    }

    public abstract void ExibirInformacoes();
}
