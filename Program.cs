using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment5._1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number");

            string number = Console.ReadLine();

            Console.WriteLine(Palindrome(number));                                                               
        
        }
        static bool Palindrome(string number)
        {
            int lastNum = number.Length-1;

            for (int i = 0; i < number.Length/2; i++)
            {
                if (number[i] != number[lastNum])
                {
                    return false;
                }
                lastNum--;
            }
            return true;
        }

    }
}
