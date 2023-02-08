using BudgetProject.Controllers;
using BudgetProjectUI;
internal class MainProgram
{
    private static void Main(string[] args)
    {
        MainUI myMainMenu = new MainUI();
        int option = myMainMenu.ChooseOption();

        if (option == 1 ) {
            ProgramController myProgramController;
            //ProgramUI myProgramUI = new ProgramUI(myProgramController);
            ProgramUI myProgramUI = new ProgramUI();
            var myprogram = myProgramUI.RequestProgramData();
        }
        

    }
}