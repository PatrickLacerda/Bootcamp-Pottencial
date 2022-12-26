using Programação_orientada_a_objeto.models;
using Programação_orientada_a_objeto.Interfaces;



ICalculadora calc = new Calculadora();
Console.WriteLine(calc.Multiplicar(3,9));

//ICalculadora calc = new ICalculadora(); comando para demostrar que não é possivel instanciar uma interface 
//**** EXEMPLO DA CLASSE OBJECT ****/


// Computador c = new Computador ();
// Console.WriteLine(c.ToString());





//**** CONSTRUTOR POR HERANÇA****//

// Pessoa p1 = new Pessoa("Patrick");
// Aluno a1 = new Aluno("Lacerda");
// Aluno a2 = new Aluno();

// a1.Apresentar();



//**** PRATICA CLASSE ABSTRATA ****/

// Corrente c = new Corrente();
// c.Creditar(500);
// c.ExibirSaldo();



//**** Herança ****//

// Aluno a1 = new Aluno();
// a1.Nome = "Patrick";
// a1.Idade = 37;
// a1.Nota = 10;
// a1.Apresentar();

// Professor p1 = new Professor(); /// HERANÇA + POLIMORFISMO
// p1.Nome = "Patrick";
// p1.Idade = 37;
// p1.Salario = 8900.00;
// p1.Apresentar();



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