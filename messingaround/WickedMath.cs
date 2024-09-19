using System;
//using System.Runtime.InteropServices;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace messingaround
{
    internal class WickedMath
    {
        public static void WickMyMath()
        {
            string[] operators = { "+", "-", "*", "/", "%" };
            string operator0;
            string operand1;
            string operand2;

            Console.WriteLine("Calculater? No, calcunow!");

            while (true)
            {
                Console.Write("Enter an operand [double]: ");
                operand1 = Console.ReadLine();
                if (Double.TryParse(operand1, out double whyisitrequired)) { break; }
                else { Console.WriteLine("This is not a double!"); }
            }

            while (true)
            {
                while (true)
                {
                    Console.Write("Enter an operator [+-*/%]: ");
                    operator0 = Console.ReadLine();
                    if (Array.Exists(operators, el => el == operator0)) { break; }
                    else { Console.WriteLine("This is not an operator!"); }
                }

                while (true)
                {
                    Console.Write("Enter an operand [double]: ");
                    operand2 = Console.ReadLine();
                    if (Double.TryParse(operand2, out double whyisitrequired)) { break; }
                    else { Console.WriteLine("This is not a double!"); }

                }

                switch (operator0)
                {
                    case "+":
                        operand1 = (Double.Parse(operand1) + Double.Parse(operand2)).ToString();
                        break;
                    case "-":
                        operand1 = (Double.Parse(operand1) - Double.Parse(operand2)).ToString();
                        break;
                    case "*":
                        operand1 = (Double.Parse(operand1) * Double.Parse(operand2)).ToString();
                        break;
                    case "/":
                        operand1 = (Double.Parse(operand1) / Double.Parse(operand2)).ToString();
                        break;
                    case "%":
                        operand1 = (Double.Parse(operand1) % Double.Parse(operand2)).ToString();
                        break;
                    default:
                        Console.WriteLine("This shouldn't happen..");
                        break;
                }

                Console.WriteLine($"Current result: {operand1}");
                Console.Write("Continue operating? [y/n]");
                string confirmation = Console.ReadLine();
                if (confirmation == "n" | confirmation == "N") { break; }
                
            }

            Console.WriteLine("Math is done.");

        }
    }
}
