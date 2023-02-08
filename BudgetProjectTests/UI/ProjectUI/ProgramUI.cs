using BudgetProject.Controllers;
using BudgetProject.Entities;
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
        internal void RequestProgramData(ProgramController controller)
        {
            DateTime startProgram;
            DateTime endProgram;
            Console.WriteLine("-- Register Program --");
            Console.Write("Introduce the program code: ");
            string code = Console.ReadLine();
            Console.Write("Introduce the program name: ");
            string name = Console.ReadLine();
            do
            {
                Console.Write("Introduce the program start date: ");
                startProgram = DateTime.Parse(Console.ReadLine());
                if (!ProgramUIValidator.IsValidProgramStartDate(startProgram))
                {
                    Console.WriteLine("Ingrese una fecha en Lunes");
                }
            }
            while (!ProgramUIValidator.IsValidProgramStartDate(startProgram));
            do
            {
                Console.Write("Introduce the program end date: ");
                endProgram = DateTime.Parse(Console.ReadLine());
                if (!ProgramUIValidator.IsValidProgramEndDate(endProgram))
                {
                    Console.WriteLine("Ingrese una fecha en Viernes");
                }
            }
            while (!ProgramUIValidator.IsValidProgramEndDate(endProgram));
            Program myProgram = new Program(code,name,startProgram,endProgram);
            int result = controller.RegisterProgram(myProgram);
            ShowResult(result);
        }

        public void ShowResult(int result)
        {
            if (result == 1)
            {
                Console.WriteLine("Program succesfully added");
                Console.WriteLine("");
            }
        }
    }
}
