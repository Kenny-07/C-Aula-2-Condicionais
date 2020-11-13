using System;

namespace C_Aula_2_Condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escreva seu ano de nascimento: ");
            int ano1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Escreva o ano atual: ");
            int ano2 = int.Parse(Console.ReadLine());

            int idade = (ano2 - ano1);
            int semanas = (idade * 52);
            
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Você tem " + idade + " anos de idade");
            Console.WriteLine("Isso é igual a " + semanas + " semanas");
        }
    }
}
