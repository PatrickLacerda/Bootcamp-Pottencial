// See https://aka.ms/new-console-template for more information
using Propriedade_Métodos_e_Construtores_C_.Models;
using System.Globalization; // importa a classe para poder mudar o padrão da moeda 



// NUGET É UM GERENCIADOR DE PACOTE, PACOTE É UM CONJUNTO DE  CODIGOS UTEIS QUE POSSIBILITA O COMPARTILHAMENTO E REUSO DO CODIGO
// PACOTE É UM PEQUENO PROJETO NO C# QUE RESOLVE UM PROBLEMA ESPECIFICO
// OBS - NUGET É APENAS NO DOTNET 
// PODE SER ACESSADO NO SITE https://www.nuget.org/


// MANEIRA CONVENCIONAL 

// int numero  = 10;

// bool ehPar = false;

// // IF TERNÁRIO - OTIMO PARA DIMINUIR QUANTIDADE DE LINHAS 
// // UTILIZA UMA VARIAVEL BOLEANA 

// ehPar = numero % 2 == 0;

// NA HORA DE VALIDAR A CONDICIONAL UTILIZA ? PARA TOMAR UMA AÇÃO CASO SEJA VERDEIRO OU FALSO

// SINTAXY CONDIÇÃO ehPar DEPOIS ?  resultado caso verdadeiro  verdadeira resultado caso falso

// Console.WriteLine($"O número {numero} é "+ (ehPar ? "par" : "impar")); 


// if(numero % 2 == 0)
// {
//     Console.WriteLine($"O número {numero} é par");
// }

// else
// {
//     Console.WriteLine($"O número {numero} é Impar");
// }




// DESCONSTRUTOR 
// TEM O OBJETIVO DE SEPARAR O OBJETO, SEPARAR AS INFORMAÇÕES EM UMA VARIAVEL DISTINTA

// Pessoa p1 = new Pessoa("Patrick","Lacerda");
// // revisar desconstructor - erro 
// (string nome, string sobrenome) = p1; // SEMELHANTE A SINTAXY DE UMA TUPLAb-

// Console.WriteLine($"{nome} {sobrenome}");


// LeituraArquivo arquivo = new LeituraArquivo();
// var (sucesso, linhasArquivo, quantidadeLinhas) = arquivo.LerArquivo("Arquivos/arquivoLeitura.txt"); // var indentificar o tipo de variavel 
// // retornar uma informação que não vai usar - DESCARTES
// //UTILIZAR O UNDERLINE _ SIGNIFICA , ESSA INFORMAÇÃO VOCÊ DESCARTA, TRAZER MAS NÃO USAR
// // EXEMPLO var (sucesso, linhasArquivo, _) = arquivo.LerArquivo("Arquivos/arquivoLeitura.txt");
// // chamar tupla do metodo
// // 

// if (sucesso)
// {   
//     Console.WriteLine("Quantidade linhas do arquivo:" + quantidadeLinhas);
//     foreach (string linha  in linhasArquivo)
//     {
//         Console.WriteLine(linha);
        
//     }
// }
// else
// {
//     Console.WriteLine("Não foi possivel ler o arquivo");
// }









//TUPLAS FORNECE SINTAXE CONCISA PARA AGRUPAR VÁRIOS ELEMENTOS DE DADOS EM UMA ESTRUTURA DE DADOS LEVE, 
//ELA NÃO É UMA COLEÇÃO MAS PODE TER DENTRO DE SI UMA COLEÇÃO

//DECLARAR UMA TUPLAS

// MANEIRA MAIS RECOMENDADA DE USAR TUPLA POR CAUSA DA LEGIBILIDADE e declaração de nomes
// (int Id,string Nome,string Sobrenome,decimal Altura) tupla = (1, "Patrick", "Lacerda", 10.5M); // uma unica variavel declarou 4 valores de diferente tipos.

// ValueTuple<int,string,string,decimal> outroExemploTupla = (1, "Patrick", "Lacerda", 10.5M); // outra forma de representar uma tupla
// var outroExemploTuplaCreate = Tuple.Create(1, "Patrick", "Lacerda", 10.5M);// outra maneira de representar - ele identifica automaticamente que e string ou inteiro





// Console.WriteLine($"ID:{tupla.Id}");
// Console.WriteLine($"Nome:{tupla.Nome}");
// Console.WriteLine($"Sobrenome:{tupla.Sobrenome}");
// Console.WriteLine($"Altura:{tupla.Altura}");

//TRABALHANDO COM DICTIONARY 
// UM DICTIONARY É UMA COLEÇÃO DE CHAVE-VALOR PARA ARMAZENAR VALORES UNICOS SEM UMA ORDEM ESPECIFICA, CASO NÃO SEJA UNICOS ELES VÃO APRESENTAR UMA EXCESSÃO
// é necessário que a chave tenha valores unicos

// Dictionary<string,string> estados = new Dictionary<string, string>(); // passar a minha chave que é string e o meu dificionario é string 

// estados.Add("SP", "São Paulo"); // adicionar itens no dictionary
// estados.Add("BA", "Bahia");
// estados.Add("MG", "Minas Gerais");


// Console.WriteLine("-------------");
// Console.WriteLine(estados["MG"]); //obter um valor do dicionario


// foreach(var item in estados)
// {
//     Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
// }



// Console.WriteLine("-------------");

// estados.Remove("BA"); //  remover um item do dicionario
// estados["SP"] = "São Paulo - valor alterado"; // alterar valores do dicionario
// foreach(var item in estados)
// {
//     Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
// }


// string chave = "BA";
// Console.WriteLine("Verificando o elemento:");
// //ContainsKey - é um metodo para verificar se a chave existe

// if (estados.ContainsKey(chave))
// {
//     Console.WriteLine($"Valor existente: {chave}");
// }
// else
// {
//     Console.WriteLine($"Valor não existe. É seguro adicionar a chave: {chave}");
// }




//TRABALHANDO COM PILHAS - ELE OBEDECE A ORDEM LIFO (LAST INT FIRST OUT) ( O ULTIMO QUE ENTROU VAI SER O PRIMEIRO QUE VAI SAIR AO CONTRARIO DE UMA FILA)

// Stack<int> pilha = new Stack<int>();

// pilha.Push(4); // adiciona o elemento na pilha
// pilha.Push(6);
// pilha.Push(8);
// pilha.Push(10);

// foreach (var item in pilha)
// {
//     Console.WriteLine(item);
// }

// Console.WriteLine($"Removento o elemento do topo: {pilha.Pop()}");

// pilha.Push(20);

// foreach (var item in pilha)
// {
//     Console.WriteLine(item);
// }

//pilha.Pop(); // remove e retorna o objeto no topo da pilha 

//TRABALHANDO COM FILAS

// Queue<int> fila = new Queue<int>();

// fila.Enqueue(2); // adiciona um elemento no final da fila
// fila.Enqueue(4);
// fila.Enqueue(6);
// fila.Enqueue(4);

//fila.Dequeue();// remove o primeiro elemento da fila, não precisa estipular o valor


// foreach (int item in fila)
// {
//     Console.WriteLine(item);
// }


// Console.WriteLine($"Removendo o elemento: {fila.Dequeue()}");
// fila.Enqueue(10);

// foreach (int item in fila)
// {
//     Console.WriteLine(item);
// }




//new ExemploExcecao().metodo1();


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