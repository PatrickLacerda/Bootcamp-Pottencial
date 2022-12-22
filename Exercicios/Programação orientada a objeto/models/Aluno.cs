using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Programação_orientada_a_objeto.models

// PARA TRABALHAR COM HERANÇA, APÓS A CLASSE COLOCAR : E DEPOIS A CLASSE QUE QUER HERDAR
{
    public class Aluno : Pessoa
    {
        public double Nota { get; set; }
    }
}