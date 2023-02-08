using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetProject.Entities
{
    public class Program
    {
        public CodeProgram Code { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public Program(CodeProgram code, string name, DateTime startDate, DateTime endDate)
        {
            this.Code= code;
            this.Name= name;
            this.StartDate= startDate;
            this.EndDate= endDate;
        }
    }
}
