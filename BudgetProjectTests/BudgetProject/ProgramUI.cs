using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetProjectUI
{
    public class ProgramUI
    {
        public void RequestProgramData()
        {
            Console.WriteLine("-- Register Program --");
            Console.Write("Introduce the program code: ");
            string code = Console.ReadLine();
            Console.Write("Introduce the program name: ");
            string name = Console.ReadLine();
            Console.Write("Introduce the program start date: ");
            string startDate = Console.ReadLine();
            Console.Write("Introduce the program end date: ");
            string endDate = Console.ReadLine();
            ProgramData myProgram = new ProgramData(code,name,startDate,endDate);
        }
    }
}
