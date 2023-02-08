using BudgetProject.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetProject.ProjectUI
{
    public class MainUI
    {
        private ControllerProgram controllerProgram;
        private ProgramUI programUI;
        public MainUI() 
        {
            controllerProgram = new ControllerProgram();
            programUI = new ProgramUI();
        
        }
        internal void Show()
        {
            while(true)
            {
                ShowMainMenu();
                try
                {
                    int userInput = ReadInt();
                    switch (userInput)
                    {
                        case 0:
                            return;
                        case 1:
                            programUI.DisplayRegisterProgram();
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
        private void ShowMainMenu()
        {
            Console.WriteLine("----------Choose an Option---------------");
            Console.WriteLine("1: Register Program.");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("0: Exit.");
            Console.WriteLine("-----------------------------------------");
        }
        private int ReadInt()
        {
            string option = Console.ReadLine();
            return int.Parse(option);
        }

    }
}
