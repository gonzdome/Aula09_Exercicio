using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula09_Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Qual a idade do primeiro aluno?");
            int primeiro = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual a idade do segundo aluno?");
            int segundo = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual a idade do terceiro aluno?");
            int terceiro = int.Parse(Console.ReadLine());

            int media = (primeiro + segundo + terceiro) / 3;
            Console.WriteLine("\nA idade média dos alunos é de " + media + " anos!");

            Console.ReadKey();


        }
    }
}
