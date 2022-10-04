using Exemplo_fundamentos.models ;


string apresentacao = "Ola seja bem vindo";
int quantidade = 1;
quantidade = 10;
double altura = 1.80;
decimal preco = 1.80m;
bool condicao = true;
DateTime dataAtual = DateTime.Now.AddDays(5); // add day adiciona dias 
// conversores de string para inteiro
//int a = Convert.ToInt32("5"); aceita valor null
//int a = int.Parse("5");
//int b = 20;

//int c = a + b;

// conversão string 

//int inteiro = 5;
//string aa = inteiro.ToString(); // to string , conversão de inteiro para string 

//Console.WriteLine(aa);

//Console.WriteLine(a);

string a ="15-";
int b = 156;
int.TryParse(a, out b);
Console.WriteLine(b);
Console.WriteLine("Conversão realizada com sucesso");

Pessoa pessoa1  = new Pessoa();
pessoa1.Nome ="Patrick Candido Lacerda";
pessoa1.Idade = 36;
pessoa1.Apresentar();

Console.WriteLine(apresentacao);
Console.WriteLine("Valor da variavel quantidade: " + quantidade);
Console.WriteLine("Valor da variavel altura: " + altura.ToString("0.00")); // conversao do double com casas decimais - recomendado usar variavel decimal
Console.WriteLine("Valor da variavel preco: " + preco);
Console.WriteLine("Valor da variavel condicao: " + condicao);
Console.WriteLine("Valor da variavel data: " + dataAtual.ToString("dd/MM/yyyy HH:mm"));