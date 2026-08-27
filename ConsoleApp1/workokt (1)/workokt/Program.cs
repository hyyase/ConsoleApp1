using Microsoft.Data.SqlClient;

var connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=workot;Integrated Security=true;";

using var conn = new SqlConnection(connectionString);
conn.Open();
Console.WriteLine("Conectado ao banco!");
conn.Close();


var dev     = new Desenvolvedor("Arthur", "DEV001", "C#");
var analista = new Analista("Maria", "ANA001");
var devOps  = new DevOps("Carlos", "DEVOPS001");
var help    = new HelpDesks("João", "HELP001");


analista.Ativo = false;


Console.WriteLine("=== Exibindo Perfis ===\n");
dev.ExibirInformacoes();
analista.ExibirInformacoes();
devOps.ExibirInformacoes();
help.ExibirInformacoes();


Console.WriteLine("\n=== Registros de Acesso ===\n");
var catraca = new Catraca();

catraca.RegistrarEntrada(dev);
catraca.RegistrarEntrada(analista); 
catraca.RegistrarEntrada(devOps);
catraca.RegistrarEntrada(help);
catraca.RegistrarSaida(dev);

Console.WriteLine("\n=== Permissões ===\n");
catraca.DefinirPermissao(dev);
catraca.DefinirPermissao(devOps);

var permissao = catraca.ObterPermissao(dev);
Console.WriteLine($"{dev.Nome} (expression) — permissão: {permissao}.");


catraca.ExibirHistorico();


Console.WriteLine("\n=== Funcionários Ativos ===\n");
var lista = new List<Funcionario> { dev, analista, devOps, help };
var filtro = new FiltroFuncionario(lista);

foreach (var f in filtro.Ativos())
    Console.WriteLine($"{f.Nome} ({f.Cargo})");

Console.WriteLine("\n=== Só Desenvolvedores ===\n");
foreach (var f in filtro.PorCargo(Cargo.Desenvolvedor))
    Console.WriteLine($"{f.Nome} ({f.Cargo})");

var dev1 = new Desenvolvedor("leticia", "dev003", "javascript");

var salarios = new Salarios();

salarios.ExibirContracheque(dev1);

Console.WriteLine(salarios.ExibirContracheque(dev1));

IPagamentos pagamento = new Salarios();

var funcionarios = new List<Funcionario>
{
    new Desenvolvedor("Arthur", "DEV001", "C#"),
    new DevOps("Carlos", "DEVOPS001"),
    new Analista("Maria", "ANA001"),
    new HelpDesks("João", "HELP001"),
};


var banco = new BancoFuncionario();

banco.Inserir(new Desenvolvedor("Arthur", "DEV001", "C#"));
banco.Inserir(new DevOps("Carlos", "DEVOPS001"));
banco.Inserir(new Analista("Maria", "ANA001"));
banco.Inserir(new HelpDesks("João", "HELP001"));

banco.ListarTodos();

Console.WriteLine("\n=== Registros de Acesso no Banco ===\n");

var bancoAcesso = new BancoRegistroAcesso();

bancoAcesso.Inserir(1, "Entrada");
bancoAcesso.Inserir(2, "Entrada");
bancoAcesso.Inserir(1, "Saída");

bancoAcesso.ListarHoje();

