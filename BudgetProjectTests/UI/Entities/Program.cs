using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetProject.Entities
{
    public class Program
    {
        public string Code;
        public string Name;
        public DateTime StartDate;
        public DateTime EndDate;

        public Program(string code, string name, DateTime startDate, DateTime endDate)
        {
            this.Code= code;
            this.Name= name;
            this.StartDate = startDate;
            this.EndDate = endDate;
        }
    }
}
