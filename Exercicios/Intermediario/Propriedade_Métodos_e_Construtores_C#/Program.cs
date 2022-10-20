// See https://aka.ms/new-console-template for more information
using Propriedade_Métodos_e_Construtores_C_.Models;

Pessoa p1 = new Pessoa(nome: "Leonardo", sobrenome: "Buta");
Pessoa p2 = new Pessoa(nome: "Patrick",sobrenome: "Lacerda");
Pessoa p3 = new Pessoa(nome: "Eduardo",sobrenome: "Queiroz");


Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Ingles";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.AdicionarAluno(p3);
cursoDeIngles.ListarAlunos();






// p1.Nome = "Patrick"; // quando tiver uma chave inglesa, representa uma proriedade 
// p1.Sobrenome = "Lacerda";


// Pessoa p2 = new Pessoa();
// p2.Nome = "Eduardo";
// p2.Sobrenome = "Neves Queiroz";