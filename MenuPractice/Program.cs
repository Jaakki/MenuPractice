using System;

namespace MenuPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu();
            }
        }
        private static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1) Reverse String");
            Console.WriteLine("2) Remove Whitespace");
            Console.WriteLine("3) Exit");
            Console.Write("\r\nSelect an option: ");

            switch (Console.ReadLine())
            {
                case "1":
                    ReverseString();
                    return true;
                case "2":
                    Whitespace();
                    return true;
                case "3":
                    return false;
                default:
                    return true;
            }
        }

        private static string CaptureInput()
        {
            Console.Write("Enter the string you want to modify: ");
            return Console.ReadLine();
        }

        private static void ReverseString()
        {
            Console.Clear();
            Console.WriteLine("Reverse String");

            char[] charArray = CaptureInput().ToCharArray();
            Array.Reverse(charArray);
            DisplayResults(String.Concat(charArray));
        }

        private static void Whitespace()
        {
            Console.Clear();
            Console.WriteLine("Remove Whitespace");

            DisplayResults(CaptureInput().Replace(" ", ""));
        }

        private static void DisplayResults(string message)
        {
            Console.WriteLine($"\r\nYour string modifier is: {message}");
            Console.Write("\r\nPress enter to return to Main Menu");
            Console.ReadLine();
        }
    }
}
