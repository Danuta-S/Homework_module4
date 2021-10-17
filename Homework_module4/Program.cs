using System;

namespace Homework_module4
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Month_Number
            Console.Write(@"Please enter a Month Number from 1 to 12 (1 = January, 2 = February," +
                $"3 = ..., etc.)" + Environment.NewLine +
                $"Test Data: ");
            string monthNumber = Console.ReadLine();
            Console.WriteLine(":");
            int m = 0;

            if (int.TryParse(monthNumber, out m))
            {
                if (m == 4 || m == 6 || m == 9 || m == 11)
                {
                    Console.WriteLine("Month have 30 days");
                }
                else if (m == 2)
                {
                    Console.WriteLine("Month has 28 or 29 days");
                }
                else if (m == 1 || m == 3 || m == 5 || m == 7 || m == 8 || m == 10 || m == 12)
                {
                    Console.WriteLine("Month have 31 days");
                }
                else
                {
                    Console.WriteLine("It is not a valid input!");
                }
            }
            else
            {
                Console.WriteLine("It is not a valid input!");
            }
           
            Console.ReadLine();
            #endregion

            #region Calculation

            Console.Write("Enter the first Integer:");
            string number1 = Console.ReadLine();

            Console.Write("Enter the second Integer:");
            string number2 = Console.ReadLine();
            int var1 = 0;
            if (int.TryParse(number1, out var1))
            {
                if (int.TryParse(number2, out int var2))
                {
                    int addition = var1 + var2;
                    int substraction = var1 - var2;
                    int multiplication = var1 * var2;
                    decimal decimalVar1 = Convert.ToDecimal(number1);
                    decimal decimalVar2 = Convert.ToDecimal(number2);
                    decimal division = decimalVar1 / decimalVar2;

                    Console.Write(Environment.NewLine);
                    Console.Write(@"Here are the options :
1 - Addition.
2 - Substraction.
3 - Multiplication.
4 - Division.
5 - Exit.");
                    Console.Write(Environment.NewLine);

                    string opt = Console.ReadLine();

                    switch (opt)
                    {
                        case "1":
                            Console.WriteLine($"{var1} + {var2} = {addition}");
                            break;
                        case "2":
                            Console.WriteLine($"{var1} - {var2} = {substraction}");
                            break;
                        case "3":
                            Console.WriteLine($"{var1} * {var2} = {multiplication}");
                            break;
                        case "4":
                            Console.WriteLine($"{decimalVar1} / {decimalVar2} = {division}");
                            break;
                        case "5":
                            break;
                        default:
                            Console.WriteLine("It is not a valid input!");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("It is not a valid input!");
                }
            }
            else
            {
                Console.WriteLine("It is not a valid input!");
            }

            Console.ReadLine();
            #endregion
        }
    }
}
