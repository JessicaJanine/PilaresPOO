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
            p1.Nome = "Jarvis (Just A Rather Very Intelligent System)";
            p1.Idade = 50;

            p1.Apresentar();

            Retangulo r = new Retangulo();
            r.DefinirMedidas(25, 50);
            System.Console.WriteLine($"Área: {r.ObterArea()}");

            Aluno a = new Aluno();
            a.Nome = "Tony";
            a.Idade = 40;
            a.Nota = 10;

            a.Apresentar();

            Professor professor = new Professor();
            professor.Nome = "Natasha";
            professor.Salario = 10000;

            professor.Apresentar();

            Diretor diretor = new Diretor();
            diretor.Nome = "Augusto";

            diretor.Apresentar();

            Calculadora calc = new Calculadora();
            System.Console.WriteLine("Resultado da primeira soma = " + calc.Somar(1,2,3));
            System.Console.WriteLine("Resultado da segunda soma = " + calc.Somar(10, 10));

            Corrente c = new Corrente();
            c.Creditar(100);

            c.ExibirSaldo();

            
        }
    }
    
}



