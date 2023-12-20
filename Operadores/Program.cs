//Operadores matemáticos e de atribuição
Console.WriteLine("Operadores matemáticos e de atribuição");

double a = 4;
Console.WriteLine(a);
double b = 4 / 2;
Console.WriteLine(b);
double c = 4 / 2 + (a * b);
Console.WriteLine(c);
double d = c / a / b;
Console.WriteLine(d);
double e = 4 - d;
Console.WriteLine(e);
double f = e + d + (c - b - a);
Console.WriteLine(f);

//Conversão de variáveis com tratamento de excessão
Console.WriteLine("Conversão de variáveis com tratamento de excessão");

string textoNumerico0 = "15";
int valorNumerico0 = Convert.ToInt32(textoNumerico0);
Console.WriteLine(valorNumerico0);
Console.WriteLine("Conversão realizada com sucesso");

//string textoNumerico1 = "15-";
//int valorNumerico1 = Convert.ToInt32(textoNumerico1);
//Console.WriteLine(valorNumerico1);
//Resulta em erro de excessão
//Unhandled exception. System.FormatException: The input string '15-' was not in a correct format.
//   at System.Number.ThrowFormatException[TChar](ReadOnlySpan`1 value)    
//   at System.Convert.ToInt32(String value)

//Alternativamente podemos usar o TryParse(Vin, out Vout)

string textoNumerico2 = "15-";
int valorNumerico2 = 0;

int.TryParse(textoNumerico2, out valorNumerico2);
Console.WriteLine(valorNumerico2);
Console.WriteLine("Conversão realizada com sucesso");

//Também dá pra declarar a variável dentro do TryParse
string textoNumerico3 = "15-";

int.TryParse(textoNumerico3, out int valorNumerico3);
Console.WriteLine(valorNumerico3);
Console.WriteLine("Conversão realizada com sucesso");
