using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace poo.Models
{
    public class Professor : Pessoa
    {
        public decimal Salario { get; set;}
         public override void Apresentar()
        {
            System.Console.WriteLine($"Olá, sou o professor: {Nome}, tenho {Idade} anos, e recebo um salário de {Salario}");
        }
    }
}