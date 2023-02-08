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
        internal void RequestProgramData()
        {
            Console.WriteLine("-- Register Program --");
            Console.Write("Introduce the program code: ");
            string code = Console.ReadLine();
            Console.Write("Introduce the program name: ");
            string name = Console.ReadLine();
            Console.Write("Introduce the program start date: ");
            DateTime startProgram= DateTime.Parse(Console.ReadLine());
            ValidatorProgram.IsValidProgramStartDate(startProgram);
            Console.Write("Introduce the program end date: ");
            DateTime endProgram = DateTime.Parse(Console.ReadLine());
            ValidatorProgram.IsValidProgramStartDate(endProgram);
        }
    }
}
