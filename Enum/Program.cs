using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumIntro
{
    public enum DaysOfTheWeek
    {
        SUNDAY=0,
        MONDAY=1,
        TUESDAY=2,
        WEDNESDAY=3,
        THURSDAY=4,
        FRIDAY=5,
        SATURDAY=6
    }
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Pick a day of the week (case-insensitive string or number from 0 to 6, 0 being Sunday)");
            string input = Console.ReadLine();
            try
            {
                if ( Enum.IsDefined(typeof(DaysOfTheWeek), input.ToUpper()) || Enum.IsDefined(typeof(DaysOfTheWeek), Convert.ToInt32( input )) )
                {
                    Console.WriteLine("It's in the enum!");
                }
                else
                {
                    Console.WriteLine("Please enter an actual day of the week");
                }
            }
            catch
            {
                Console.WriteLine("Please enter an actual day of the week");
            }          
        }
    }
}
