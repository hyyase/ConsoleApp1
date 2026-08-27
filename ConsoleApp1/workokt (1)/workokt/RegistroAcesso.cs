public record RegistroAcesso
{
    public Funcionario Funcionario { get; }
    public DateTime DataHora { get; }
    public string TipoEvento { get; }

    public RegistroAcesso(Funcionario funcionario, string tipoEvento)
    {
        Funcionario = funcionario;
        DataHora = DateTime.Now;
        TipoEvento = tipoEvento;
    }

    public void ExibirRegistro()
    {
        Console.WriteLine($"[{DataHora:dd/MM/yyyy HH:mm}] {TipoEvento} — {Funcionario.Nome} ({Funcionario.Cargo})");
    }
}
