using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogo_de_Adivinha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool corect = false;
            Random random = new Random();
            int randomnumb = random.Next(1, 11);
            Console.WriteLine("Vamos brincar de adivinha");
            Console.WriteLine("eu VOU escolher um numero de 1 a 10");
            Console.WriteLine("e voce vai tentar adivinhar!");

            while (!corect)
            {
                Console.WriteLine("adivinhe");
                int guess = Convert.ToInt32(Console.ReadLine());
                if (guess > randomnumb)
                {
                    Console.WriteLine("muito alto");
                }
                if (guess < randomnumb)
                {
                    Console.WriteLine("Baixo demais");
                }
                if (guess == randomnumb)
                {
                    Console.WriteLine("Parabens [:");
                    corect = true;
                }
            }
        }
    }
}
