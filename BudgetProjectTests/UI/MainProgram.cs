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

        // See https://aka.ms/new-console-template for more information

        Console.WriteLine("Hello, World!");
        MainUI mainMenu = new MainUI();
        mainMenu.Show();

    }
}