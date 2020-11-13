using System;

namespace C_Aula_2_Condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=============================================");
            Console.WriteLine("Bem vindo a seletiva para o time de Valorant");
            Console.WriteLine("=============================================");
            Console.WriteLine("Você gostaria de participar ?? (Sim ou Não)");
            string resposta = Console.ReadLine();
                if(resposta == "Sim"){
                    Console.WriteLine("Que legal! Agora vamos analisar seu curriculo.");
                    Console.WriteLine("Insira sua media escolar");
                    int media = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite a quantidade de faltas:");
                    int faltas = int.Parse(Console.ReadLine());
                    if(media >=50 && faltas <= 10) {
                        Console.WriteLine("Parabens seja bem vindo =D");

                    }else{
                        Console.WriteLine("Que Pena, você precisa melhorar suas notas e faltas");
                    }
                }else{
                    Console.WriteLine("Blz, passar bem");
                }
        }
    }
}
