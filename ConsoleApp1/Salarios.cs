
public class Salarios : IPagamentos
    {
  
    
        private static readonly Dictionary<Cargo, int> _salariosBases = new()
    {
        { Cargo.Desenvolvedor, 500000 },
        { Cargo.DevOps,        600000 },
        { Cargo.Analista,      450000 },
        { Cargo.HelpDesks,     350000 },
        { Cargo.Gerente,       900000 },
    };

        private static readonly Dictionary<Cargo, int> _bonus = new()
    {
        { Cargo.Desenvolvedor, 50000 },
        { Cargo.DevOps,        60000 },
        { Cargo.Analista,      40000 },
        { Cargo.HelpDesks,     30000 },
        { Cargo.Gerente,      100000 },
    };

        private static readonly int _descontoINSS = 11;

        public int ObterSalarioBase(Cargo cargo) => _salariosBases[cargo];
        public int ObterBonus(Cargo cargo) => _bonus[cargo];

        public int CalcularDesconto(Cargo cargo)
        {
            int base_ = ObterSalarioBase(cargo);
            return base_ * _descontoINSS / 100;
        }

        public int CalcularLiquido(Cargo cargo)
        {
            return ObterSalarioBase(cargo) + ObterBonus(cargo) - CalcularDesconto(cargo);
        }

        public string ExibirContracheque(Funcionario funcionario)
        {
            int salarioBase = ObterSalarioBase(funcionario.Cargo);
            int bonus = ObterBonus(funcionario.Cargo);
            int desconto = CalcularDesconto(funcionario.Cargo);
            int liquido = CalcularLiquido(funcionario.Cargo);

            return $@"
=== Contracheque ===
Nome:         {funcionario.Nome}
Cargo:        {funcionario.Cargo}
Salário base: R$ {salarioBase / 100},{salarioBase % 100:00}
Bônus:        R$ {bonus / 100},{bonus % 100:00}
INSS:        -R$ {desconto / 100},{desconto % 100:00}
Líquido:      R$ {liquido / 100},{liquido % 100:00}
====================";
        }
    }



