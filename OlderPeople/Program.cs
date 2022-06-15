using OlderPeople.Class;
using System;

namespace OlderPeople
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Programa que lê Idade e nome do Usuário
            People p = new People();
            Console.Write("Insert your name: ");
            p.Name = Console.ReadLine();
            Console.Write("Insert you age: ");
            p.Years = int.Parse(Console.ReadLine());
            Console.Write("Your name is " + p.Name + " and " + "your age is " + p.Years);
         
        }
    }
}
