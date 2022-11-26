using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Propriedade_Métodos_e_Construtores_C_.Models
{
    public class LeituraArquivo
    {
        public (bool Sucesso, string[] Linhas, int QuantidadeLinhas) LerArquivo(string caminho) // tupipa em metodo
        {
            try
            {
            
                string[] linhas = File.ReadAllLines(caminho);
            
                return(true, linhas, linhas.Count());

            }catch(Exception ex)
            {
                return(false,new string[0],0);
            }

        }
    }
}