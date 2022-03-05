using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilaresPOO.Models
{
    public abstract class Conta
    {
        protected double saldo;

        public abstract void Creditar(double valor);

        public void ExibirSaldo()
        {
            System.Console.WriteLine($"Seu saldo é: {saldo} ");
        }

    }
}
