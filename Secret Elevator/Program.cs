using System;
using System.Collections.Generic;
using System.Threading;

namespace SecretElevator
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Title = "PROJECT: SECRET ELEVATOR";

            Dictionary<int, string> accessCodes = new Dictionary<int, string>();
            accessCodes.Add(135, "First Floor - Lobby");
            accessCodes.Add(246, "Second Floor - Research Lab");
            accessCodes.Add(357, "Third Floor - IT Department");
            accessCodes.Add(999, "Fourth Floor - Executive Suite");
            accessCodes.Add(579, "Fifth Floor - Rooftop Garden");
            accessCodes.Add(0, "Basement - RESTRICTED AREA");

            while (true)
            {
                Console.Clear();

                Console.ForegroundColor = ConsoleColor.Cyan;

                Console.WriteLine("");
                Console.WriteLine("      __________________  ");
                Console.WriteLine("     |  ______________  | ");
                Console.WriteLine("     | |              | | ");
                Console.WriteLine("     | |   SECRET     | | ");
                Console.WriteLine("     | |  ELEVATOR    | | ");
                Console.WriteLine("     | |              | | ");
                Console.WriteLine("     | |______________| | ");
                Console.WriteLine("     |__________________| ");
                Console.WriteLine("");

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("[ SYSTEM LOCKED ]");
                Console.Write("Enter Access Code: ");

                string inputString = GetMaskedInput();

                Console.WriteLine("");
                Console.WriteLine("Verifying identity...");

                Thread.Sleep(800);

                int code;
                if (int.TryParse(inputString, out code))
                {
                    if (accessCodes.ContainsKey(code))
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("");
                        Console.WriteLine("ACCESS GRANTED.");

                        Console.Beep(1000, 200);

                        Console.WriteLine("Transporting to: " + accessCodes[code]);

                        Console.Write("Going up");
                        for (int i = 0; i < 5; i++)
                        {
                            Console.Write(".");
                            Thread.Sleep(400);
                        }

                        Console.WriteLine("");
                        Console.WriteLine("*Ding!* You have arrived.");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("");
                        Console.WriteLine("ACCESS DENIED. Invalid Code.");
                        Console.Beep(200, 500);
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("");
                    Console.WriteLine("ERROR: System accepts numeric input only.");
                }

                Console.ResetColor();
                Console.WriteLine("");
                Console.WriteLine("Press any key to try again...");
                Console.ReadKey(true);
            }
        }

        static string GetMaskedInput()
        {
            string pass = "";
            ConsoleKeyInfo key;

            while (true)
            {
                key = Console.ReadKey(true);

                if (key.Key == ConsoleKey.Enter)
                {
                    break;
                }

                if (key.Key == ConsoleKey.Backspace)
                {
                    if (pass.Length > 0)
                    {
                        pass = pass.Substring(0, pass.Length - 1);
                        Console.Write("\b \b");
                    }
                }
                else
                {
                    pass = pass + key.KeyChar;
                    Console.Write("*");
                }
            }

            return pass;
        }
    }
}
