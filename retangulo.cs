using System;
using System.Globalization;
namespace TresNotasdosAlunos;
class Programa
{
    static void Main(string[] args)

    {
        Console.WriteLine("Projeto  - notas");
        Console.WriteLine();




        notass alunosnota = new notass();


        Console.WriteLine("Quantos alunos terão as notas digitas?");
        int quantidadealunos = int.Parse(Console.ReadLine());


        for (int i = 0; i < quantidadealunos; i++)
        {


            Console.WriteLine("\\//\\//\\//\\//\\//\\//\\/");
            Console.WriteLine("Digite as três notas do aluno " + (i + 1));

            Console.WriteLine("A primeira nota foi: ");
            alunosnota.nota = double.Parse(Console.ReadLine());

            Console.WriteLine("A segunda nota foi: ");
            alunosnota.notb = double.Parse(Console.ReadLine());

            Console.WriteLine("A terceira nota foi:");
            alunosnota.notc = double.Parse(Console.ReadLine());


            double notafinal = alunosnota.final();


            if (notafinal > 60)

            {
                Console.WriteLine("APROVADO");

                Console.WriteLine("Sua nota final foi: " + notafinal);
            }

            else

            {
                Console.WriteLine("REPROVADO");
                Console.WriteLine("Sua nota final foi: " + notafinal);
                Console.WriteLine("Faltam " + (notafinal - 60));
            }



        }



        Console.WriteLine();
        Console.WriteLine("Pressione ENTER para encerrar.");
        Console.ReadLine();
    }
}