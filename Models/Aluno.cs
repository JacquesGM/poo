using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace poo.Models
{
    public class Aluno : Pessoa
    {
        public decimal Nota { get; set; }
        public override void Apresentar()
        {
            System.Console.WriteLine($"Olá, meu nome é: {Nome}, tenho {Idade} anos, e sou um aluno nota {Nota}");
        }
    }
}