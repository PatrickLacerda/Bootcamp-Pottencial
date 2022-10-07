using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OperadoresAritimeticos.models 
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

         public void Potencia (int x, int y)
         {
            double pot = Math.Pow(x,y);
            Console.WriteLine($"{x} ^ {y} = {pot}");
         }

         public void Seno(double angulo)
         {  
            double radiano = angulo * Math.PI / 180 ;
            double seno = Math.Sin(radiano);
            Console.WriteLine($"Seno de {angulo} = {Math.Round(seno,4)}");
         }

         public void Coseno(double angulo)
         {  
            double radiano = angulo * Math.PI / 180 ;
            double coseno = Math.Cos(radiano);
            Console.WriteLine($"Coseno de {angulo} = {Math.Round(coseno,4)}"); // math.Round responsável por arredondar numeros e estipular casas  decimais
         }

          public void Tangente(double angulo)
         {  
            double radiano = angulo * Math.PI / 180 ; // conversor de radiano
            double tangente = Math.Tan(radiano);
            Console.WriteLine($"Tangente de {angulo} = {Math.Round(tangente,4)}");
         }

         public void RaizQuadrada(double x)
         {
           double raiz =   Math.Sqrt(x); // sqrt representa raiz  quadrada
            Console.WriteLine($"RRaiz quadrada de {x} = {raiz}");
         }
    }
}