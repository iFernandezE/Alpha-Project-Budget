using BudgetProject.Entities;
using BudgetProject.Controllers;
using BudgetProject.Utilitaries;

namespace BudgetProjectTests.ProgramTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestSaveProgramWhenIsRegister()
        {
            Program myProgram = new Program("DEV-01", "Fullstack 38", DateTime.Parse("06/02/2023"), DateTime.Parse("30/06/2023"));
            ProgramController myProgramController = new ProgramController();

            int res = myProgramController.RegisterProgram(myProgram);
            Assert.AreEqual(1, res);
        }

        [TestMethod]
        public void TestValidateStartDateProgramIsMondayReturnsTrue() {
            Program myProgram = new Program("DEV-01", "Fullstack 38", DateTime.Parse("06/02/2023"), DateTime.Parse("30/06/2023"));
            bool res = ProgramUIValidator.IsValidProgramStartDate(myProgram.StartDate);
            Assert.AreEqual(true, res);
        }

        [TestMethod]
        public void TestValidateEndDateProgramIsFridayReturnsTrue()
        {
            Program myProgram = new Program("DEV-01", "Fullstack 38", DateTime.Parse("06/02/2023"), DateTime.Parse("30/06/2023"));
            bool res = ProgramUIValidator.IsValidProgramEndDate(myProgram.EndDate);
            Assert.AreEqual(true, res);
        }

        [TestMethod]
        public void TestValidateStartDateProgramIsNotMondayReturnsFalse()
        {
            Program myProgram = new Program("DEV-01", "Fullstack 38", DateTime.Parse("07/02/2023"), DateTime.Parse("30/06/2023"));
            bool res = ProgramUIValidator.IsValidProgramStartDate(myProgram.StartDate);
            Assert.AreEqual(false, res);
        }

        [TestMethod]
        public void TestValidateEndDateProgramIsNotFridayReturnsFalse()
        {
            Program myProgram = new Program("DEV-01", "Fullstack 38", DateTime.Parse("06/02/2023"), DateTime.Parse("29/06/2023"));
            bool res = ProgramUIValidator.IsValidProgramEndDate(myProgram.EndDate);
            Assert.AreEqual(false, res);
        }
    }
}