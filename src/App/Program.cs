using System;

namespace App
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Fibonnaci Sequence!");
            if(args.Length == 1)
            {
                int sequence = int.Parse(args[0]);
                Console.WriteLine("The number is {0}", CalculateFibonacci(sequence));
            } else{
                Console.WriteLine("Enter the sequence number of the number to be calculated:");
                int sequence = int.Parse(Console.ReadLine());
                Console.WriteLine("The number is {0}", CalculateFibonacci(sequence));
            }
        

        }

        private static int CalculateFibonacci(int sequence)
        {
           int number1 = 0;
           int number2 = 1;
           int number = 0;

           switch (sequence)
           {
               case 0:
                   number = number1;
                   break;
               case 1:
                   number = number2;
                   break;
               default:
                   {
                       for (int i = 3; i <= sequence; i++)
                       {
                           number = number1 + number2;
                           number1 = number2;
                           number2 = number;
                       }
                       break;
                   }
           }
           return number;
        }
    }
}