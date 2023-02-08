using BudgetProject.Controllers;
using BudgetProject.Entities;
using BudgetProject.ProjectUI;

internal class MainProgram
{
    private static void Main(string[] args)
    {
        //MainUI myMainMenu = new MainUI();
        //int option = myMainMenu.ChooseOption();

        //if (option == 1)
        //{
        //    ProgramController myProgramController;
        //    ProgramUI myProgramUI = new ProgramUI(myProgramController);
        //}

        MainUI mainMenu = new MainUI();
        ProgramUI programUI= new ProgramUI();
        int option = mainMenu.Show();

        while (true)
        {            
            try
            {
                switch (option)
                {
                    case 0:
                        return;
                    case 1:
                        programUI.RequestProgramData();
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

    }
}