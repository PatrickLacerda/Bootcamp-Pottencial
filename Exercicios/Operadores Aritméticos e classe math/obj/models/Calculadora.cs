using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Operadores_Aritméticos_e_classe_math.obj.models
{
    public class Calculadora
    {
         public void Somar(int x , int y)
         {
            Console.WriteLine ($"{x} + {y} = {x + y}");

         }
         public void Subtrair(int x , int y)
         {
            Console.WriteLine ($"{x} - {y} = {x - y}");

         }
        
        public void Multiplicar(int x , int y)
         {
            Console.WriteLine ($"{x} X {y} = {x * y}");

         }

         public void Dividir(int x , int y)
         {
            Console.WriteLine ($"{x} / {y} = {x / y}");

         }
    }
}