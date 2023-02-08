using BudgetProject.Entities;
using System.Collections.ObjectModel;

namespace BudgetProject.Repositories
{

    public class ProgramRepository
    {
        public List<Program> ProgramList = new List<Program>();

        public ProgramRepository()
        {
        }

        public IEnumerable<Program> GetAll()
        {
            return ProgramList;
        }

        public void Add(Program program)
        {
            ProgramList.Add(program);
        }
    }
}
