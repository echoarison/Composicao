using System;
using System.Globalization;
using Composicao.Entities;
using Composicao.Entities.Enums;

namespace Composicao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter department's name: ");
            string deptName = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Enter worker data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Level (Junitor/MidLevel/Senior): ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());    //convertendo para Enum
            Console.Write("Base Salary: $");
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); //convertendo string em double

            //instanciando os objetos
            Department dept = new Department(deptName); //usando a sobrecarga do construtor
            Worker worker = new Worker(name, level, baseSalary, dept);

            Console.WriteLine();

            //perguntando quantos contratis vai cadastrar
            Console.Write("How many contracts to this worker?: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine();

            //fazendo um for para executar o numero que o usuario pediu
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Enter #{i+1} contract data:");
                Console.Write("Date (DD/MM/YYYY): " );
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("value per hour: $");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Duration (hours): ");
                int hours = int.Parse(Console.ReadLine());

                //instanciando objeto com construtor / sobrecarga
                HourContract contract = new HourContract(date, valuePerHour, hours);

                //adicionando o contrato do trabalhador
                worker.AddContract(contract);
            }

            Console.WriteLine();
            
            //perguntando o mes e o ano para ver o total do lucro dos contartos
            Console.Write("Enter month and year to calculate income (MM/YYYY): ");
            string monthAndYear = Console.ReadLine();
            int month = int.Parse(monthAndYear.Substring(0,2)); //recortando a partir na posição 0 á duas casas
            int year = int.Parse(monthAndYear.Substring(3));
            Console.WriteLine("Name: " + worker.GetName());
            Console.WriteLine("Department: " + worker.GetDepartment());
            Console.WriteLine("Income for " + monthAndYear + ": $" + worker.Income(year, month).ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
