using PilaresPOO.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilaresPOO.Models
{
    public class Calculadora : ICalculadora
    {
        public int Dividir(int n1, int n2)
        {
            return n1 / n2;
        }

        public int Multiplicar(int n1, int n2)
        {
            return n1 * n2;
        }

        public int Somar (int num1, int num2)
        {
            return num1 + num2;
        }

        public int Somar (int num1, int num2, int num3)
        {
            return num1 + num2 + num3;
        }

        public int Subtrair(int n1, int n2)
        {
            return n1 - n2;
        }
    }
}
