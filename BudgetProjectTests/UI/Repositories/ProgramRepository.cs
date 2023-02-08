using System.Collections.ObjectModel;

namespace BudgetProject.Repositories
{

    internal class ProgramRepository
    {
        private static ObservableCollection<Program> collection;

        public ProgramRepository()
        {
        }

        public IEnumerable<Program> GetAll()
        {
            return collection;
        }

        public void Add(Program program)
        {
            collection.Add(program);
        }
    }
}
