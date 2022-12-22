using Programação_orientada_a_objeto.models;


//**** Herança ****//

Aluno a1 = new Aluno();
a1.Nome = "Patrick";
a1.Idade = 37;
a1.Apresentar();
a1.Nota = 10;

Professor p1 = new Professor();
p1.Nome = "Patrick";
p1.Idade = 37;
p1.Salario = 8900.00;

//**** ENCAPSULAMENTO ****//

// ContaCorrente c1 = new ContaCorrente(123, 1000);
// c1.ExibirSaldo();
// c1.Sacar(500);
// c1.ExibirSaldo();


//**** ABSTRAÇÃO ****//
// Pessoa p1 = new Pessoa();
// p1.Nome = "Patrick";
// p1.Idade = 37;

// p1.Apresentar();