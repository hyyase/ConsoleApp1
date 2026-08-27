public class FiltroFuncionario
{
    private List<Funcionario> _lista;

    public FiltroFuncionario(List<Funcionario> lista)
    {
        _lista = lista;
    }

    public IEnumerable<Funcionario> Ativos()
    {
        foreach (var f in _lista)
        {
            if (f.Ativo)
                yield return f;
        }
    }

    public IEnumerable<Funcionario> PorCargo(Cargo cargo)
    {
        foreach (var f in _lista)
        {
            if (f.Cargo == cargo)
                yield return f;
        }
    }
}
