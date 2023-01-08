using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tipos_especiais_no_C.Models

// TIPOS GENERICOS COLOCANDO T QUE SIGNIFICA TYPE- TIPOS, SE TORNANDO UMA CLASSE GENERICA
{
    public class MeuArray <T> // calsse generica sempre vai ter sinal de maior e menor
    {   
        private static int capacidade = 10;
        private int contador = 0;
        private T[] array = new T[10];

        public void AdicionarElementoArray(T Elemento)
        {
            if (contador +1 <11)
            {
                array[contador] = Elemento;
            }
            contador++;
        }

        public T this[int index]
        {
            get {return array[index];}
            set {array[index] = value;}
        }

    }
}