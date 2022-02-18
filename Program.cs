// See https://aka.ms/new-console-template for more information
using PilaresPOO.Models;
using System;

namespace PilaresPOO
{

    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa();
            p1.Nome = "Jarvis";
            p1.Idade = 50;

            p1.Apresentar();

            Retangulo r = new Retangulo();
            r.DefinirMedidas(25, 50);
            System.Console.WriteLine($"Área: {r.ObterArea()}");

            
        }
    }
    
}



