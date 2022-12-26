using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Programação_orientada_a_objeto.Interfaces;

namespace Programação_orientada_a_objeto.models
{
    public class Calculadora :ICalculadora // Classe calculadora que implmenta uma interface calculadora
    // calculadora implementa a interface calculadora e não herda
    {
        // NÃO FOI COLOCADO O METODO DIVIDIR PORQUE NA INTERFACE FOI COLOCADO UM RETORNO NO METODO DIVIDIR, SE TORNANDO OPCIONAL NA HORA DE IMPLMENTAR 
  

        public int Multiplicar(int num1, int num2)
        {
            return num1 * num2;
        }

        public int Somar (int num1, int num2)
        {
            return num1 + num2;
        }
                public int Somar (int num1, int num2, int num3)
        {
            return num1 + num2 + num3;
        }

        public int Subtrair(int num1, int num2)
        {
            return num1 - num2;
        }
    }
}