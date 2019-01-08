using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool displayMenu = true;
            while (displayMenu)
            {
                displayMenu = MainMenu();
            }

        }

        private static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Welcome to the calculator made by Regan Dufort");
            Console.Write("enter the numbers you wish to calculate!");
            Console.WriteLine("Choose an option to calculate: ");
            Console.WriteLine("1) Choose to Add your numbers");
            Console.WriteLine("2) Choose to Subtract your numbers");
            Console.WriteLine("3) Choose to Multiply your numbers");
            Console.WriteLine("4) Choose to Divide your numbers");
            Console.WriteLine("5) Choose to Exit");
            string result = Console.ReadLine();

            if (result == "1")
            {
                Sum();
                return true;

            }
            else if (result == "2")
            {
                Subtract();
                return true;
            }
            else if (result == "3")
            {
                Multiply();
                return true;
            }
            else if (result == "4")
            {
                Divide();
                return true;
            }
            else if (result == "5")
            {

                return false;
            }
            else
            {
                return true;
            }
        }

        private static void Sum()
        {

            Console.WriteLine("Type your numbers to perform Addition");
            Console.Write("Enter your first number");

            int firstnum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your second number");
            int secondnum = Convert.ToInt32(Console.ReadLine());

            int total = firstnum + secondnum;



            Console.WriteLine($"You are adding {firstnum} and {secondnum}, which equates to {total}");
            Console.ReadLine();

        }
        private static void Subtract()
        {



            Console.WriteLine("Type your numbers to perform Subtraction");
            Console.Write("Enter your first number");

            int firstnum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your second number");
            int secondnum = Convert.ToInt32(Console.ReadLine());

            int total = firstnum - secondnum;

            Console.WriteLine($"You are Subtracting {secondnum} from {firstnum}, which equates to {total}");
            Console.ReadLine();
        }
        private static void Multiply()
        {
            Console.WriteLine("Type your numbers to perform Multiplication");
            Console.Write("Enter your first number");

            int firstnum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your second number");
            int secondnum = Convert.ToInt32(Console.ReadLine());

            int total = firstnum * secondnum;

            Console.WriteLine($"You are Multiplying {firstnum} by {secondnum}, which equates to {total}");
            Console.ReadLine();
        }
        private static void Divide()
        {
            Console.WriteLine("Type your numbers to perform Division");
            Console.Write("Enter your first number");

            int firstnum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your second number");
            int secondnum = Convert.ToInt32(Console.ReadLine());

            int total = firstnum / secondnum;

            Console.WriteLine($"You are Dividing {firstnum} by {secondnum}, which equates to {total}");
            Console.ReadLine();
        }


    }
}

