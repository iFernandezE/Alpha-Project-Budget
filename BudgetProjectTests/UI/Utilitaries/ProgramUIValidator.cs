using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace BudgetProject.Utilitaries
{
    public static class ProgramUIValidator
    {
        public static bool IsValidProgramStartDate(DateTime start)
        {
           return start.DayOfWeek == DayOfWeek.Monday;
        }
        public static bool IsValidProgramEndDate(DateTime end)
        {
            return end.DayOfWeek == DayOfWeek.Friday;
        }
        //public static bool IsvalidCodeProgram(string code)
        //{
        //    bool res=false;
        //    string[] firstPart = code.Split('-');
        //    if(firstPart==null)
        //    {
        //        res = false;
        //    }
        //    else
        //    {
        //        //if (Regex.IsMatch(firstPart, "^[a-zA]*$"))
        //        //{

        //        //}
        //        if (Regex.IsMatch(firstPart, "^[a-zA-Z0-9]*$"))
        //        {
        //            Console.WriteLine("Alphanumeric String");
        //        }
        //        else
        //        {
        //            Console.WriteLine("Non-Alphanumeric String");
        //        }

        //    }
            

        //    return res;
        //}
    }
}
