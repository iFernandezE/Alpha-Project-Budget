using BudgetProject.Entities;
using BudgetProject.Repositories;
using BudgetProject.Utilitaries;
using System;

namespace BudgetProject.Controllers
{
    public class ProgramController
    {
        public ProgramRepository repository = new ProgramRepository();
        public int RegisterProgram(Program program)
        {
            ProgramValidator myProgramValidate = new ProgramValidator(program);

            int resultCode = myProgramValidate.ValidateData();
            if (resultCode == 1)
            {
                repository.Add(program);
            }
            return resultCode;
        }

    }


}
