using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetProjectUI
{
    public class ProgramData
    {
        public string Code;
        public string Name;
        public DateOnly StartDate;
        public DateOnly EndDate;

        public ProgramData(string code, string name, DateTime startDate, DateTime endDate) {
            
        }
    }
}
