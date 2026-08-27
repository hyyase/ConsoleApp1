
public interface IPagamentos
{
    int ObterSalarioBase(Cargo cargo);
    int ObterBonus(Cargo cargo);
    int CalcularDesconto(Cargo cargo);
    int CalcularLiquido(Cargo cargo);
    string ExibirContracheque(Funcionario funcionario);
}


  