public class Catraca
{
    private List<RegistroAcesso> _registros = new();

    public RegistroAcesso RegistrarEntrada(Funcionario funcionario)
    {
        if (!funcionario.Ativo)
        {
            Console.WriteLine($"Acesso negado — {funcionario.Nome}. Funcionário inativo.");
            return null;
        }

        var registro = new RegistroAcesso(funcionario, "Entrada");
        _registros.Add(registro);
        Console.WriteLine($"[{registro.DataHora:dd/MM/yyyy HH:mm}] {funcionario.Nome} entrou.");
        return registro;
    }

    public RegistroAcesso RegistrarSaida(Funcionario funcionario)
    {
        if (!funcionario.Ativo)
        {
            Console.WriteLine($"Acesso negado — {funcionario.Nome}. Funcionário inativo.");
            return null;
        }

        var registro = new RegistroAcesso(funcionario, "Saída");
        _registros.Add(registro);
        Console.WriteLine($"[{registro.DataHora:dd/MM/yyyy HH:mm}] {funcionario.Nome} saiu.");
        return registro;
    }

    public void DefinirPermissao(Funcionario funcionario)
    {
        switch (funcionario.Cargo)
        {
            case Cargo.Desenvolvedor:
                Console.WriteLine($"{funcionario.Nome} — permissão: repositório.");
                break;
            case Cargo.DevOps:
                Console.WriteLine($"{funcionario.Nome} — permissão: infraestrutura.");
                break;
            case Cargo.Analista:
                Console.WriteLine($"{funcionario.Nome} — permissão: sistema.");
                break;
            case Cargo.HelpDesks:
                Console.WriteLine($"{funcionario.Nome} — permissão: chamados.");
                break;
            default:
                Console.WriteLine($"{funcionario.Nome} — sem permissão definida.");
                break;
        }
    }

    public string ObterPermissao(Funcionario funcionario)
    {
        return funcionario.Cargo switch
        {
            Cargo.Desenvolvedor => "repositório",
            Cargo.DevOps        => "infraestrutura",
            Cargo.Analista      => "sistema",
            Cargo.HelpDesks     => "chamados",
            _                   => "sem permissão"
        };
    }

    public void ExibirHistorico()
    {
        Console.WriteLine("\n=== Histórico de Acessos ===");
        foreach (var r in _registros)
        {
            r.ExibirRegistro();
        }
    }
}
