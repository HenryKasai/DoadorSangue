using System;

namespace DoadorSangue
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Por favor, insira sua idade: ");
            bool idadebool = Int32.TryParse(Console.ReadLine(), out idade);
            if (!idadebool)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Valor inválido.");
                Console.ResetColor();
                Environment.Exit(-1);
            }
            else 
            {
                if(idade > 67 || idade < 18)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Você não pode ser um doador de sangue.");
                }
                else if (idade >= 18 || idade <= 67)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Você pode ser um doador de sangue.");
                }
                Console.ResetColor();
            }
            Console.ReadKey();
        }
    }
}
