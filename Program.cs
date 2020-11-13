using System;

namespace C_Aula_2_Condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escreva sua idade: ");
            int idade = int.Parse(Console.ReadLine());

            int meses = (idade * 12);
            int dias = (idade * 365);
            int horas = (idade * 8760);
            int minutos = (idade * 525600);
            int nascimento = (2020 - idade);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Você nasceu em " + nascimento);
            Console.WriteLine("Isso é igual a: " + meses + " meses");
            Console.WriteLine("Isso é igual a: " + dias + " dias");
            Console.WriteLine("Isso é igual a: " + horas + " horas");
            Console.WriteLine("Isso é igual a: " + minutos + " minutos");
        }
    }
}
