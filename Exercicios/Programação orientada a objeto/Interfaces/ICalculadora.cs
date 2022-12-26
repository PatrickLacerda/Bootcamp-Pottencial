using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programação_orientada_a_objeto.Interfaces
{
    public interface ICalculadora // inferface- não tem public porque por padrão ele entende que seja publico, e tb não tem implementação {}
    {
        int Somar (int num1, int num2);
        int Subtrair (int num1, int num2);
        int Multiplicar (int num1, int num2);
        int Dividir (int num1, int num2)
        {
            return num1 / num2; // A PARTIR DE QUANDO COLOCA UM CORPO NO METODO , NA HORA DA IMPLEMENTAÇÃO SE TORNA OPCIONAL
        }
    }
}