using BudgetProject.Utilitaries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetProject.ProjectUI
{
    internal class ProgramUI
    {
        internal void DisplayRegisterProgram()
        {
            Console.WriteLine("Enter the Code:");
            string code = Console.ReadLine();
            Console.WriteLine("Enter the name:");
            string name = Console.ReadLine();
            Console.WriteLine("Ingrese the Date start");
            DateTime startProgram= DateTime.Parse(Console.ReadLine());
            ValidatorProgram.IsValidProgramStartDate(startProgram);
            Console.WriteLine("Ingrese the date end ");
            DateTime endProgram = DateTime.Parse(Console.ReadLine());
            ValidatorProgram.IsValidProgramStartDate(endProgram);


        }
    }
}
