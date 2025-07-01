using System;
using System.Globalization;
using System.Collections.Generic;
using projeto13;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantos funcionários serão registrados?: ");
            int n = int.Parse(Console.ReadLine());

            List<Funcionario> funcionarios = new List<Funcionario>();

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Funcionário #" + i + ":");
                Console.WriteLine("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine("Nome: ");
                string nome = (Console.ReadLine());
                Console.WriteLine("Salário: ");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                funcionarios.Add(new Funcionario(id, nome, salario));
            }

            Console.WriteLine("\r\nInsira o ID do funcionário que terá aumento salarial: ");
            int buscarId = int.Parse(Console.ReadLine());

            Funcionario encontrar = funcionarios.Find(x => x.Id == buscarId); //expressão lambda. Para cada elemento x na lista, verifique se x.Id é igual a buscarId.
             if (encontrar != null)
            {
                Console.WriteLine("Entre com a porcentagem do aumento: ");
                double porc = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                encontrar.AumentarSalario(porc);

            }
            else
            {
                Console.WriteLine("Esse id não existe!");
            }

            Console.WriteLine();
            Console.WriteLine("Atualizar lista de funcionários:");
            foreach (Funcionario obj in funcionarios) // percorre o "Funcionario" na lista e imprime. So funciona se tiver um ToString.
            {
                Console.WriteLine(obj);
            }



        }
    }
}