using BudgetProject.Controllers;
using BudgetProject.Entities;
using BudgetProject.ProjectUI;

internal class MainProgram
{
    public static void Main(string[] args)
    {

        MainUI mainMenu = new MainUI();
        ProgramUI programUI = new ProgramUI();
        ProgramController programController = new ProgramController();
        int option;
        bool uiState = true;

        while (uiState)
        {
            try
            {
                option = mainMenu.Show();
                switch (option)
                {
                    case 1:
                        programUI.RequestProgramData(programController);
                        break;
                    case 5: 
                        uiState = false;
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