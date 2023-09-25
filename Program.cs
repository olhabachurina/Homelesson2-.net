using System;
using System.Globalization;


namespace Homelesson2.net
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Exercise 4.");

            Console.WriteLine("Enter a six-ditit number:");
            string inputNumber = Console.ReadLine();
            if (inputNumber.Length != 6)
            {
                Console.WriteLine("Error! Enter a six-digit number!");
                return;
            }
            Console.WriteLine("Enter digit numbers to replace digits (for example 1,6):");
            string[] positions = Console.ReadLine().Split(' ');
            if (positions.Length != 2)
            {
                Console.WriteLine("Error! Enter two digit numbers.");
                return;
            }
            if (!int.TryParse(positions[0], out int position1) || !int.TryParse(positions[1], out int position2))
            {
                Console.WriteLine("Error! Enter correct digit numbers.");
                return;
            }

            if (position1 < 1 || position1 > 6 || position2 < 1 || position2 > 6)
            {
                Console.WriteLine("Error! The digit numbers must be from 1 to 6..");
                return;
            }


            char[] numberArray = inputNumber.ToCharArray();// Преобразование строки в массив символов для выполнения замены цифр


            char temp = numberArray[position1 - 1];// Меняем местами цифры
            numberArray[position1 - 1] = numberArray[position2 - 1];
            numberArray[position2 - 1] = temp;

            string resultNumber = new string(numberArray);
            Console.WriteLine("Replacement result: " + resultNumber);

            Console.Write("Exercise 5.");

            Console.Write("Enter date in DD.MM.YYYY format: ");
            string inputDate = Console.ReadLine();

            if (DateTime.TryParseExact(inputDate, "dd.MM.yyyy", null, DateTimeStyles.None, out DateTime date))
            {
                string season = GetSeason(date);
                string dayOfWeek = date.ToString("dddd", new CultureInfo("en-US"));

                Console.WriteLine(season + " " + dayOfWeek);
            }
            else
            {
                Console.WriteLine("Error! Invalid date format.");
            }
        }

        static string GetSeason(DateTime date)
        {

            int month = date.Month;

            if (month >= 3 && month <= 5)
            {
                return "Spring";
            }
            else if (month >= 6 && month <= 8)
            {
                return "Summer";
            }
            else if (month >= 9 && month <= 11)
            {
                return "Autumn";
            }
            else
            {
                return "Winter";
            }
            
            Console.Write("Exercise 7.");
            Console.Write("Enter first number: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            int num2 = int.Parse(Console.ReadLine());

            
            int start = Math.Min(num1, num2);
            int end = Math.Max(num1, num2);

            Console.WriteLine("Even numbers in the range from " + start + " before " + end + ":");

            for (int i = start; i <= end; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}

