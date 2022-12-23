using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programação_orientada_a_objeto.models
{
    //public class Diretor : Professor // como a classe professor está seleada a classe diretor não pode derivar do professor causando erro no programa 
    //{
        
   // }

   public class Diretor : Professor
   {

    
        public override void Apresentar()
        {
            Console.WriteLine($"Diretor");
        }

   }
}