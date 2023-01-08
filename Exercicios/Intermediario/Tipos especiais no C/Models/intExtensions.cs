using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tipos_especiais_no_C.Models
{
    public static class intExtensions //todo metodo que trabalha com inteiro vai aparecer o metodo abaixo
    {
        public static bool EhPar(this int numero)
        {
            return numero % 2 == 0;
        }
    }
}