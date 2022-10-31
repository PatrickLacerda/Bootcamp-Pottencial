using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Propriedade_Métodos_e_Construtores_C_.Models
{
    public class ExemploExcecao
    {
        public  void metodo1()
        {  
            try
            {
                metodo4();
            } catch(Exception ex)
            {
                Console.WriteLine("Excessão tratada. " + ex.Message);
            }

        }
         public  void metodo2()
        {
            metodo3();
        }
         public  void metodo3()
        {
            metodo3();
                        
        }

         public  void metodo4()
        {
            throw new Exception("Ocorreu uma excessão");
        }

    }


}