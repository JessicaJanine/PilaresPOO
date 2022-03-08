using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilaresPOO.Models
{
    public class Diretor : Pessoa
    {
        //diretor não pode herdar de professor, porque marquei professor como classe selada e classes seladas não podem ter outras derivadas delas
        public override void Apresentar()
        {
            Console.WriteLine($"Olá eu sou o diretor {Nome}");

            //métodos também podem ser selados e nesse caso, não é possível sobreescrever em nenhuma clase filha.

            //OBS: a classe System.Object está no topo da herança ou seja, tudo em C# .NET herda dela.
        }
    }
}
