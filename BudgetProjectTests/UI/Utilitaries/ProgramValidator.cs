using BudgetProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetProject.Utilitaries
{
    internal class ProgramValidator
    {
        private Program program;

        public ProgramValidator(Program program)
        {
            this.program = program;
        }

        public int ValidateData()
        {
            return 1;
        }

    }
}
