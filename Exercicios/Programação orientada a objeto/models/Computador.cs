using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Programação_orientada_a_objeto.models
{
    //**** EXEMPLO DA CLASSE OBJECT ****/
    public class Computador : Object // exemplo de classe object -- Object mãe de todas as classes, tudo vai herdar dessa classe, não sendo necessário colocar : Object
    
    {
        public override string ToString()
        {
            return "Metodo tostring sobrescrito";
        }
        
    }
}