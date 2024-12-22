namespace C43_G03_C_04
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Q01

            Console.Write("Enter the number: ");
            int.TryParse(Console.ReadLine() , out int number);

            if (number % 3 == 0 && number % 4 == 0)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }


            #endregion

            #region Q02



            #endregion

        }

        //1st Question

        public static void FirstQuestion (int x) 
        {
            int number = x;

            
        }

        //2nd Question
        public static void SecondQuestion(int x)
        {
            int number = x;

            if (number > 0)
            {
                Console.WriteLine("Positave");
            }
            else if (number < 0)
            {
                Console.WriteLine("Negative");
            }
            else
            {
                Console.WriteLine("The number is Zero");
            }
        }


        //3rd Question
        public static void FindMaxAndMin(int a, int b, int c)
        {
            int max = a;
            if (b > max) max = b;
            if (c > max) max = c;

            int min = a;
            if (b < min) min = b;
            if (c < min) min = c;

            Console.WriteLine($"Max element = {max}");
            Console.WriteLine($"Min element = {min}");
        }

        //4th Question
        public static void OddEven(int number)
        {
            if (number % 2 == 0 && number != 0)
            {
                Console.WriteLine("Even");
            }
            else if (number == 0)
            {
                Console.WriteLine("Zero");
            } else
            {
                Console.WriteLine("Odd");
            }
        }

        //5th Question

        public static void CheckVowel(char input)
        {


            input = char.ToLower(input);
            if (input == 'a' || input == 'e' || input == 'i' || input == 'o' || input == 'u')
            {
                Console.WriteLine("Vowel");
            }
            else
            {
                Console.WriteLine("Consonant");
            }
        }

    }
}