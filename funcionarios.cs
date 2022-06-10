using System;

namespace dados_funcionario;

class Programa
{
    static void Main(string[] args)

    {
        Console.WriteLine("Projeto  - ");
        Console.WriteLine();

        //string funcionario;

        funcionarios colaborador = new funcionarios();


        Console.WriteLine("Digite a quantidade de funcionarios a serem reavaliados");
        int qtdfunciorio = int.Parse(Console.ReadLine());

        for (int i = 0; i < qtdfunciorio; i++)

        {

            Console.WriteLine("||||||||||||||||||||||||||||||||||||||||||||||");

            Console.WriteLine("funcionario" + (i + 1));

            Console.WriteLine("Qual o nome do funcionario? ");
            colaborador.nome = Console.ReadLine();

            Console.WriteLine("Qual o salario bruto do funcionario? ");
            colaborador.salario = double.Parse(Console.ReadLine());

            Console.WriteLine("Quantos de imposto o funcionario tera que pagar");
            colaborador.imposto = double.Parse(Console.ReadLine());


            double total = colaborador.liq();
            double porcentagem = colaborador.Porcentagem();

            Console.WriteLine("o seu salario liquido será de " + total);



            Console.WriteLine("Digite um aumento para o funcionario");
            colaborador.aumento = double.Parse(Console.ReadLine());

            Console.WriteLine("O valor com aumento é: " + (porcentagem + total));

        }

        Console.WriteLine();
        Console.WriteLine("Pressione ENTER para encerrar.");
        Console.ReadLine();
    }
}