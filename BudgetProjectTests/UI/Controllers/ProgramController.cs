using BudgetProject.Entities;
using BudgetProject.Repositories;
using BudgetProject.Utils;
using System;

namespace BudgetProject.Controllers
{
    internal class ProgramController
    {
        public Program program;

        public ProgramController(Program program)
        {
            this.program = program;
        }

        public int RegisterProgram()
        {
            ProgramValidate myProgramValidate = new ProgramValidate(program);
            int resultCode = myProgramValidate.ValidateData();
            if (resultCode == 1)
            {
                ProgramRepository myProgramRepository = new ProgramRepository();
                myProgramRepository.Add(program);
            }
            return 1;
        }

    }


}
