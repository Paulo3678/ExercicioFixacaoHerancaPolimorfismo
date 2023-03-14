using System;
using ExercicioFixacao1.Entities;
using System.Globalization;
using ExercicioFixacao1.Entities;

namespace ExercicioFixacao1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());
            List<Pessoa> pessoas = new List<Pessoa>();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data: ");
                Console.Write("Individual or company (i/c)? ");
                char escolha = char.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if(escolha == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double health = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    pessoas.Add(new PessoaFisica(name, anualIncome, health));

                }else if(escolha == 'c')
                {
                    Console.Write("Number of employees: ");
                    int employees = int.Parse(Console.ReadLine());
                    pessoas.Add(new PessoaJuridica(name, anualIncome, employees));
                }
            }

            Console.WriteLine();
            Console.WriteLine("TAXES PAID:");
            double totalTaxes = 0.0;

            foreach(Pessoa pessoa in pessoas)
            {
                double actualTaxe = pessoa.CalcularImposto();
                Console.WriteLine($"{pessoa.Nome}: $ {actualTaxe.ToString("F2", CultureInfo.InvariantCulture)}");
                totalTaxes += actualTaxe;
            }

            Console.WriteLine();
            Console.WriteLine($"TOTAL TAXES: $ {totalTaxes.ToString("F2", CultureInfo.InvariantCulture)}");

        }
    }
}