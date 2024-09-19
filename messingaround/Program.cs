using System;

namespace messingaround
{
    internal class Program
    {
        static void Main()
        {
            const byte ANSWER = 42;
            string coolstring;
            
            coolstring = "it's a string and it's cool";
            Console.WriteLine(coolstring);
            if (coolstring is string) { Console.WriteLine("\t" + true); }
            if (!(coolstring is null)) { Console.WriteLine("\t\t\t" + true); }

            WriteLiterals();

            Console.WriteLine("don't take it so literal!");
            Console.WriteLine(ANSWER);
            Console.WriteLine();


            WickedDays.Days();

            Console.ReadKey();
        }

        static void WriteLiterals()
        {
            char[] chars = { '\t', '\u000f', '\u0001', '\u000e', '\n'};
            Console.Out.NewLine = "";
            foreach (char c in chars)
            {
                if (c != '\t') { Console.WriteLine(c + " "); }
                else { Console.WriteLine(c); Console.WriteLine(c); }
            }
            Console.Out.NewLine = "\r\n";
        }
    }
}
