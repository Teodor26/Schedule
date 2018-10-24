using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bussines.Logic;


namespace GroupsList
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Schedule schedule = new Schedule();
            bool finish = true;
            do
            {
                Console.Clear();
                Console.WriteLine("Hello.Please enter the login:");
                schedule.Login = Console.ReadLine();
                Console.WriteLine("Enter the password:");
                schedule.Password = Console.ReadLine();
            } while (schedule.SystemIn()) ;          
            schedule.MadeGroup();
            Console.WriteLine("You are in the system.");

            while (finish)
            {               
                Console.WriteLine("Input the name of new student.");
                schedule.student = Console.ReadLine();           
                Console.Clear();
                Console.WriteLine("Opt the group which you want to be study in:");
                schedule.ShowGroup();
                Int32.TryParse(Console.ReadLine(), out int choosenGroup);
                Console.Clear();
                schedule.GetInGroup(choosenGroup);
                Console.WriteLine($"Tipe {1} if you want to log out or something else to resume:");
                int.TryParse(Console.ReadLine(),out int Logout);
                if(Logout==1)
                {
                    finish = false;
                }

            }
               
        }
    }
}
