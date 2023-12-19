using ExemploFundamentos.Models;

//Pessoa p1 = new Pessoa();
//p1.Nome = "Leonardo";
//p1.Idade = 27;
//p1.apresentar();

string apresentação = "Olá, seja bem vindo!";

int quantidade = 1;
quantidade = 10;

double altura = 1.80;

decimal preco = 1.80M;

bool condicao = true;

DateTime dataAtual = DateTime.Now;

Console.WriteLine("Valor da variável apresentação: " + apresentação);
Console.WriteLine("Valor da variável quantidade: " + quantidade);
Console.WriteLine("Valor da variável condicao: " + condicao);
Console.WriteLine("Valor da variável altura: " + altura);
Console.WriteLine("Valor da variável preco: " + preco);
Console.WriteLine("Valor da variável dataAtual: " + dataAtual);
Console.WriteLine("Vou mudar a data(+5 dias)");
dataAtual = dataAtual.AddDays(5);
Console.WriteLine("Horas da variável dataAtual: " + dataAtual.ToString("HH"));
Console.WriteLine("Minutos da variável dataAtual: " + dataAtual.ToString("mm"));
Console.WriteLine("Segundos da variável dataAtual: " + dataAtual.ToString("ss"));
Console.WriteLine("Dia da variável dataAtual: " + dataAtual.ToString("dd"));
Console.WriteLine("Mês da variável dataAtual: " + dataAtual.ToString("MM"));
Console.WriteLine("Ano da variável dataAtual: " + dataAtual.ToString("yyyy"));
