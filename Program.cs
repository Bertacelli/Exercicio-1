using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercíco: 1 ");

            Console.WriteLine("Escreva o seu nome: ");
            string nome;
            nome = Console.ReadLine();

            Console.WriteLine("Escreva a nota do trabalho: ");
            double trabalho;
            trabalho = Convert.ToDouble(Console.ReadLine());

            Console.Write("\nDigite a nota da 1° prova: ");
            double prova1;
            prova1 = double.Parse(Console.ReadLine());

            Console.Write("\nDigite a nota da 2° prova: ");
            double prova2;
            prova2 = double.Parse(Console.ReadLine());

            double media;
            media = (trabalho + prova1 + prova2) / 3;

            if (media >= 8.5)
            {
                Console.WriteLine(nome + " conceguiu conceito A ");
            }

            else if (media >= 7)
            {
                Console.WriteLine(nome + " conceguiu conceito B ");
            }

            else if (media >= 6)
            {
                Console.WriteLine(nome + " conceguiu conceito C ");
            }

            else if (media > 0)
            {
                Console.WriteLine(nome + " conceguiu conceito D ");
            }

            else if (media == 0)
            {
                Console.WriteLine(nome + " conceguiu conceito F ");
            };
        }
    }
}
