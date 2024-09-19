using System;
using static messingaround.WickedDays;

namespace messingaround
{
    internal class InfoGathering
    {
        public static void GatherInfo()
        {
            Console.WriteLine("Finally, time for a small talk.");

            while (true)
            {
                Console.Write("What's your name? ");
                var name = Console.ReadLine();
                Console.WriteLine("Fancy name. You're not from this parts, I reckon.");

                byte age;
                while (true)
                {
                    Console.Write("What's your age again? ");
                    if (byte.TryParse(Console.ReadLine(), out age)) { break; }
                    else { Console.WriteLine("Quit fooling around, just answer!"); }
                }

                Console.Write("When were you born? ");
                var birthdate = Console.ReadLine();
                Console.WriteLine("No way!");

                int favdayind;
                while (true)
                {
                    Console.WriteLine("Use an index number to answer the next question. Or else.");
                    Console.Write("What's your favourite day of week? ");
                    try { favdayind = Convert.ToByte(Console.ReadLine()); }
                    catch (FormatException) { continue; }
                    if (Array.Exists(new int[] { 1, 2, 3, 4, 5, 6, 7 }, el => el == favdayind)) { break; }
                }
                Console.WriteLine("Out of all seven? Well, okay.");
                var favday = (WickedDays.DaysOfWeek)favdayind;

                Console.WriteLine($"So, your name is {name} and your favourite day of the week is {favday},\n" +
                    $"you were born at {birthdate} and currently are {age} yearls old.\n" +
                    $"Based on this info, I'm gonna guess that your favourite colour is..");
                Array colours = Enum.GetValues(typeof(WickedDays.Semaphore));
                Console.WriteLine("\t....");
                WickedDays.Semaphore colour = (WickedDays.Semaphore)colours.GetValue(new Random().Next(colours.Length));
                Console.WriteLine("..is {0}, of course.", colour);
                Console.Write("Is that correct? [y/n] ");
                var confirmation = Console.ReadLine();
                if (confirmation == "y" | confirmation == "Y")
                {
                    Console.WriteLine("Great! See ya.");
                    break;
                }
                else { Console.WriteLine("I see, well, let's try this again then."); }
            }
        }
    }
}
