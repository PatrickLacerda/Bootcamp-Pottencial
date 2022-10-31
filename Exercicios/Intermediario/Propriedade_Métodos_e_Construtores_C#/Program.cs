// See https://aka.ms/new-console-template for more information
using Propriedade_Métodos_e_Construtores_C_.Models;
using System.Globalization; // importa a classe para poder mudar o padrão da moeda 



new ExemploExcecao().metodo1();


// EXCEÇÕES E COLEÇÕES

// try // tente fazer alguma coisa , ele vai executar o código com mais cautela, porem está ciente que pode acontecer algum erro

// {

//     string[] linhas = File.ReadAllLines("Arquivos/arquivoLeitura.txt");

//     foreach (string linha in linhas)
//     {
//         Console.WriteLine(linha);
//     }



// } 

// catch(FileNotFoundException ex)
// {
//     Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Arquivo não encontrado {ex.Message}");
// }
// catch(DirectoryNotFoundException ex)
// {
//     Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Caminho da pasta não encontrado" + ex.Message);
// }


// catch (Exception ex) // catch significa pegar , obter - o codigo vai pegar a excessão 
// {
//     Console.WriteLine($"Ocorreu uma excessão genérica. {ex.Message}");
// }
// finally // serve para executar um bloco de código, sempre no final da execuçao, indepedente se ocorrer uma excessão ou não.
// // pode usar por exemplo para fechar uma conexão com o banco evitando que a conexão não fique com a conexão travada
// // segura a conexão consome memoria etc
// {
//     Console.WriteLine("Chegou até arquivo");
// }









//MANIMULÇÃO DE DATAS 

// string dataString = "2022-04-17 18:00";

// bool dataValidada = DateTime.TryParseExact(dataString,"yyyy-MM-dd HH:mm",CultureInfo.InvariantCulture,DateTimeStyles.None, out DateTime data); 

// if (dataValidada)
// {
//     Console.WriteLine($"Conversão com sucesso Data: {data}");
// }
// else
// {
//     Console.WriteLine($" {dataValidada} não é uma data válida");
// }

// converte a data para o formato desajado
// ele vai receber a string que quero converter, formato que ela está, depois pede a cultura
//InvariantCulture  se, cultura especifica, estilo do date time(DateTimeStyles.None - caso não queira estilo), depois a saida out date time para variavel data
//declarar DataTime

//DateTime data = DateTime.Now; // pega sua hora atual 
//DateTime data = DateTime.Parse(dataString); // recebe a hora digitada.
//Console.WriteLine(data.ToString("dd/MM/yyyy HH:mm")); // formatação de data
//Console.WriteLine(data.ToShortDateString()); // fornece apenas a data
//Console.WriteLine(data.ToShortTimeString()); // fornece apenas a hora
//Console.WriteLine(data);



















// CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("en-US"); // mudou para moeda americana de acorod com a cultura do sistema colocado

// decimal valorMonetario = 1582.40M;


// //Console.WriteLine($"{valorMonetario:C}");// quando faço interpolação de string e coloco 2: significa que eu quero formatar
// // o valor por exemplo :C - formata o valor em uma moeda - Formatação se baseia na localização do sistema.
// //Console.WriteLine(valorMonetario.ToString("C",CultureInfo.CreateSpecificCulture("en-US"))); // outra forma de formatar uma moeda parao utra cultura
// // muito usado para codigo avançado, se a linguagem for portugues, ingles, etc 
// //FORMATAÇÃO PERSONALIZADA 
// Console.WriteLine(valorMonetario.ToString("C5")); // C REPRESENTA QUANTIDADE DE NUMEROS DECIMAIS

// double porcentagem = .3421;

// Console.WriteLine(porcentagem.ToString("P")); // ToString("P") deixa o valor formatado em porcentagem

// int numero = 123456;
// Console.WriteLine(numero.ToString("##-##-##")); // esse # representa um numero , formatação personalizada de numero com traços.





// string numero1 = "10";
// string numero2 = "20";

// string resultado = numero1 + numero2;

// Console.WriteLine(resultado);








// Pessoa p1 = new Pessoa(nome: "Leonardo", sobrenome: "Buta");
// Pessoa p2 = new Pessoa(nome: "Patrick",sobrenome: "Lacerda");
// Pessoa p3 = new Pessoa(nome: "Eduardo",sobrenome: "Queiroz");


// Curso cursoDeIngles = new Curso();
// cursoDeIngles.Nome = "Ingles";
// cursoDeIngles.Alunos = new List<Pessoa>();

// cursoDeIngles.AdicionarAluno(p1);
// cursoDeIngles.AdicionarAluno(p2);
// cursoDeIngles.AdicionarAluno(p3);
// cursoDeIngles.ListarAlunos();






// p1.Nome = "Patrick"; // quando tiver uma chave inglesa, representa uma proriedade 
// p1.Sobrenome = "Lacerda";


// Pessoa p2 = new Pessoa();
// p2.Nome = "Eduardo";
// p2.Sobrenome = "Neves Queiroz";