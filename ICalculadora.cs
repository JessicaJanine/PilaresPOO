using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilaresPOO.Interfaces
{
    public interface ICalculadora
    {
        int Somar(int n1, int n2);
        int Subtrair(int n1, int n2);
        int Multiplicar(int n1, int n2);
        int Dividir(int n1, int n2)
        {
            return n1 / n2;
        }
        //Um método implementado na interdace pode não ser implementado na classe e puxado direto da interface.
        //Os demais métodos não implementados aqui tem que ser implementados na classe obrigatoriamente.
    }
}
