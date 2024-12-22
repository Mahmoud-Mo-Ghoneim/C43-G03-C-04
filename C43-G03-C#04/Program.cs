using static System.Runtime.InteropServices.JavaScript.JSType;

namespace C43_G03_C_04
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Q01

            //Console.Write("Enter the number: ");
            //int.TryParse(Console.ReadLine() , out int number);

            //if (number % 3 == 0 && number % 4 == 0)
            //{
            //    Console.WriteLine("Yes");
            //}
            //else
            //{
            //    Console.WriteLine("No");
            //}


            #endregion

            #region Q02
            //Console.Write("Enter the number: ");
            //int.TryParse(Console.ReadLine(), out int number);

            //if (number < 0)
            //{
            //    Console.WriteLine("Negative");
            //}
            //else if (number > 0)
            //{
            //    Console.WriteLine("Positive");
            //}
            //else 
            //{ 
            //    Console.WriteLine("Zero");
            //}

            #endregion


            #region Q03
            //Console.Write("Enter the First Number: ");
            //int.TryParse(Console.ReadLine(), out int numb1);
            //Console.Write("Enter the Second Number: ");
            //int.TryParse(Console.ReadLine(), out int numb2);
            //Console.Write("Enter the Third Number: ");
            //int.TryParse(Console.ReadLine(), out int numb3);

            //int max = numb1;
            //if (numb2 > max) max = numb2;
            //if (numb3 > max) max = numb3;

            //int min = numb1;
            //if (numb2 < min) min = numb2;
            //if (numb3 < min) min = numb3;

            //Console.WriteLine($"Max element = {max}");
            //Console.WriteLine($"Min element = {min}");

            #endregion

            #region Q04
            //Console.Write("Enter the Number: ");
            //int.TryParse(Console.ReadLine(), out int number);

            //if (number % 2 == 0 && number != 0) {
            //    Console.WriteLine("Even");
            //} else if (number == 0)
            //{
            //    Console.WriteLine("Your Number is Zero");
            //} else
            //{
            //    Console.WriteLine("odd");
            //}
            #endregion


            #region Q05
            //Console.Write("Enter the character: ");
            //char.TryParse(Console.ReadLine(), out char input);

            //if (input == 'a' || input == 'e' || input == 'i' || input == 'o' || input == 'u')
            //{
            //    Console.WriteLine("Vowel");
            //}
            //else if (char.IsLetter(input))
            //{
            //    Console.WriteLine("Consonant");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input");
            //}
            #endregion

            #region Q06
            //Console.Write("Enter the number: ");
            //int.TryParse(Console.ReadLine(), out int number);

            //for (int i = 1; i < number + 1; i++)
            //{
            //    Console.WriteLine(i);
            //}
            #endregion



            #region Q07
            //Console.Write("Enter the number: ");
            //int.TryParse(Console.ReadLine(), out int number);

            //for (int i = 1; i <= 12; i++)
            //{
            //    int x = number * i;
            //    Console.WriteLine(x);
            //}

            #endregion



            #region Q08
            //Console.Write("Enter the number: ");
            //int.TryParse(Console.ReadLine(), out int number);

            //for (int i = 1; i <= number; i++)
            //{
            //    if (i % 2 == 0) Console.Write($"{i} ");

            //}

            #endregion


            #region Q09
            //Console.Write("Enter the base number: ");
            //int.TryParse(Console.ReadLine(), out int baseNumber);
            //Console.Write("Enter the exponent number: ");
            //int.TryParse(Console.ReadLine(), out int exponent);
            //int result = 1;

            //for (int i = 1; i <= exponent; i++)
            //{
            //    result *= baseNumber;
            //}
            //Console.WriteLine(result);
            #endregion


            #region Q10
            //Console.Write("Enter marks for subject 1: ");
            //int.TryParse(Console.ReadLine(), out int subject1);

            //Console.Write("Enter marks for subject 2: ");
            //int.TryParse(Console.ReadLine(), out int subject2);

            //Console.Write("Enter marks for subject 3: ");
            //int.TryParse(Console.ReadLine(), out int subject3);

            //Console.Write("Enter marks for subject 4: ");
            //int.TryParse(Console.ReadLine(), out int subject4);

            //Console.Write("Enter marks for subject 5: ");
            //int.TryParse(Console.ReadLine(), out int subject5);

            //int total = subject1 + subject2 + subject3 + subject4 + subject5;
            //double average = total / 5.0;
            //double percentage = (total / 500.0) * 100;

            //Console.WriteLine($"Total marks = {total}");
            //Console.WriteLine($"Average marks = {average}");
            //Console.WriteLine($"Percentage = {percentage}");

            #endregion


            #region Q11
            //Console.Write("Enter the month number (1-12): ");
            //int.TryParse(Console.ReadLine(), out int monthNumber);

            //int daysInMonth;

            //if (monthNumber == 1 || monthNumber == 3 || monthNumber == 5 || monthNumber == 7 ||
            //    monthNumber == 8 || monthNumber == 10 || monthNumber == 12)
            //{
            //    daysInMonth = 31;
            //}
            //else if (monthNumber == 4 || monthNumber == 6 || monthNumber == 9 || monthNumber == 11)
            //{
            //    daysInMonth = 30;
            //}
            //else if (monthNumber == 2)
            //{
            //    daysInMonth = 28;
            //}
            //else
            //{
            //    Console.WriteLine("Invalid month number.");
            //    return;
            //}

            //Console.WriteLine($"Days in Month: {daysInMonth}");

            #endregion


            #region Q12
            //Console.Write("Enter the First number : ");
            //double.TryParse(Console.ReadLine(), out double num1);
            //Console.Write("Enter the Second number : ");
            //double.TryParse(Console.ReadLine(), out double num2);
            //Console.Write("Enter the operation (+, -, *, /): ");
            //char.TryParse(Console.ReadLine(), out char operation);

            //double result = 0;
            //bool validOperation = true;

            //switch (operation)
            //{
            //    case '+':
            //        result = num1 + num2;
            //        break;
            //    case '-':
            //        result = num1 - num2;
            //        break;
            //    case '*':
            //        result = num1 * num2;
            //        break;
            //    case '/':
            //        if (num2 != 0)
            //            result = num1 / num2;
            //        else
            //        {
            //            Console.WriteLine("Error: Division by zero.");
            //            validOperation = false;
            //        }
            //        break;
            //    default:
            //        Console.WriteLine("Invalid operation.");
            //        validOperation = false;
            //        break;
            //}

            //if (validOperation) Console.WriteLine($"Result: {result}");
            #endregion

            #region Q13
            //Console.Write("Enter a string: ");
            //string input = Console.ReadLine();

            //char[] charArray = input.ToCharArray();
            //Array.Reverse(charArray);
            //string output = new string(charArray);
            //Console.WriteLine($"Reversed string: {output}");

            #endregion


            #region Q14
            //Console.Write("Enter an integer: ");
            //int.TryParse(Console.ReadLine(), out int number);
            //int reversed = 0;
            //while (number != 0)
            //{
            //    int digit = number % 10;
            //    reversed = reversed * 10 + digit;
            //    number /= 10;
            //}
            //Console.WriteLine($"Reversed number: {reversed}");
            #endregion

        }
    }
 }