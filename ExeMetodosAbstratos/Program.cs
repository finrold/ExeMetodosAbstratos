using ExeMetodosAbstratos.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace ExeMetodosAbstratos
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Imposto> lista = new List<Imposto>();

            Console.Write("Quantidade de empresas e pessoas físicas: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Pagador de imposto #{i}: ");
                Console.Write("Pessoa Física ou Jurídica (f/j)? ");
                char tipo = char.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Renda Anual: ");
                double rendaAnual = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if(tipo == 'f')
                {
                    Console.Write("Gastos com saúde: ");
                    double gastosSaude = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    lista.Add(new PessoaFisica(nome, rendaAnual, gastosSaude));
                }
                else
                {
                    Console.Write("Número de empregados: ");
                    int numeroFuncionarios = int.Parse(Console.ReadLine());
                    lista.Add(new PessoaJuridica(nome, rendaAnual, numeroFuncionarios));
                }
            }

            double sum = 0;
            Console.WriteLine();
            Console.WriteLine("Imposto Pago:");

            foreach (Imposto tax in lista)
            {
                double taxa = tax.Taxa();
                Console.WriteLine(tax.Nome
                    + ": R$ "
                    + taxa.ToString("F2"), CultureInfo.InvariantCulture);
                sum += taxa;
            }

            Console.WriteLine();
            Console.WriteLine("Imposto Total: R$ " + sum.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
