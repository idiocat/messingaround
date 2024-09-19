using System;
using System.Threading;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//no idea why it's here

namespace messingaround
{
    internal class WickedDays
    {
        const char SPACE = ' ';

        public static void Days()
        {
            combo(DaysOfWeek.Moonday, Semaphore.Blue);
            combo(DaysOfWeek.Sunday, Semaphore.Red);
            combo(DaysOfWeek.Caturday, Semaphore.Black);
            combo(DaysOfWeek.Toothsday, Semaphore.Yellow);

            Console.WriteLine();

            randomcombo();
            randomcombo();
            randomcombo();
            randomcombo();
        }

        static void combo(DaysOfWeek day, Semaphore colour)
        {
            Console.WriteLine(colour.ToString() + SPACE + day.ToString());
        }

        static void randomcombo()
        {
            Random R = new Random();
            Array days = Enum.GetValues(typeof(DaysOfWeek));
            Array colours = Enum.GetValues(typeof(Semaphore));
            DaysOfWeek day = (DaysOfWeek)days.GetValue(R.Next(days.Length));
            Semaphore colour = (Semaphore)colours.GetValue(R.Next(colours.Length));
            Console.WriteLine(colour.ToString() + SPACE + day.ToString());
        }

        public enum DaysOfWeek : byte
        {
            Moonday = 1,
            Toothsday,
            Woundsday,
            Thorsday,
            Freeday,
            Caturday,
            Sunday,
        }

        public enum Semaphore : int
        {
            Red = 100,
            Green = 200,
            Blue = 300,
            Yellow = 600,
            Black = 650,
            Purple = 800,
            Orange = 801,
        }
    }
}
