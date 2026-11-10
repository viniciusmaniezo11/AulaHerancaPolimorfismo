using Heranca;

Gerente g1 = new Gerente();

g1.Nome = "Vinicius Maniezo";
g1.Codigo = 123;


g1.Trabalhar();

g1.GerenciarEquipe();

g1.DefinirSalario(5000m);

g1.ExibirSalario();

Funcionario funcionario = new Gerente("Maria", 5000m, 456); //* Não é possivel chamar os métodos do Gerente pois é do tipo Funcionario

Funcionario f1 = new Gerente();
Funcionario f2 = new Desenvolvedor();

f1.Trabalhar();
f2.Trabalhar();

Console.WriteLine(f1.CalcularBonus());
Console.WriteLine(f2.CalcularBonus());

Desenvolvedor d1 = new Desenvolvedor();

d1.CalcularBonus();

IPagamento pix = new PagamentoPix();
IPagamento cartao = new PagamentoCartao();

pix.Pagar(199);
cartao.Pagar(200);