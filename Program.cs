using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Nome
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            // Console.Write("(c)Raziel, 2022\n");
            Console.Write("Escreva o seu nome: ");
            nome = Convert.ToString(Console.ReadLine());
            Console.Write("\n");
            Console.Write("O seu nome é: " + nome);
            Console.Write("\n\nAperte uma tecla para sair...");
            Console.ReadKey();
        }
    }
}
