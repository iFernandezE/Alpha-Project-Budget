using BudgetProject.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetProject.ProjectUI
{
    public class MainUI
    {
        internal int Show()
        {
            Console.WriteLine("--- Alpha Project ---");
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1. Register program");
            Console.WriteLine("2. ");
            Console.WriteLine("3. ");
            Console.WriteLine("4. ");
            Console.WriteLine("5. Exit");
            return Convert.ToInt32(Console.ReadLine());            
        }

    }
}
