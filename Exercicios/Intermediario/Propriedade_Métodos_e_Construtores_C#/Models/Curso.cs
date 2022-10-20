using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Propriedade_Métodos_e_Construtores_C_.Models
{
    public class Curso
    {
        public string Nome{ get; set; }
        public List<Pessoa> Alunos { get; set; }
        
    
        public void AdicionarAluno(Pessoa aluno) // void significa vazio () argumento ou parametro
        {
            Alunos.Add(aluno);
        }

        public int ObterQuantidadeDeAlunosMatriculados()
        {
            int quantidade = Alunos.Count;
            return quantidade;
        }

        public bool RemoverAluno(Pessoa aluno)
        {
            return Alunos.Remove(aluno);
            
        }

        public void ListarAlunos()
        {
            Console.WriteLine($"Aluno do curso de {Nome}");

            for (int count = 0; count < Alunos.Count; count++)
            {
                string texto = "Nº" + count + " - " + Alunos[count].NomeCompleto; // sinal de + conctenação
                Console.WriteLine(texto);
                            }
            // foreach (Pessoa aluno in Alunos)
            // {
            //     Console.WriteLine(aluno.NomeCompleto);
            // }
        }

    }
}