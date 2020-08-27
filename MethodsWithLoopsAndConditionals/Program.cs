using System;
using System.IO;
using System.Security.Cryptography;

namespace MethodsWithLoopsAndConditionals
{
    class Program
    {
        static void Main(string[] args)
        {

            NumCounter();

            SkipNumCounter();
            
            Console.WriteLine(AreNumbersSame(1, 2));
            AreNumEvenOrOdd(4);
            Console.WriteLine(PosOrNeg(-143));

            Console.WriteLine("How old is the potential voter?");
            var userInput = Console.ReadLine();
            var age = int.Parse(userInput);
            OfVotingAge(age);
        }

        public static void NumCounter()
        {
            for (int i = -1000; i <= 1000; i++)
            {
                Console.WriteLine(i);
            }
        }

        public static void SkipNumCounter()
        {
            for (int i = 3; i <= 999; i += 3)
            {
                Console.WriteLine(i);
            }

        }


        public static bool OfVotingAge(int age)
        {
            if (age>=18)
            {
                Console.WriteLine("Yes you can vote");
                return true;
            }
            else
            {
                Console.WriteLine("No they are too young");
                return false;
            }

        }
        public static bool AreNumbersSame(int a,int b)
        {
            if (a == b)
            { return true; }
            else
            { return false; }
        }
        public static void AreNumEvenOrOdd(int a)
        {
            if (a % 2 == 0)
                Console.WriteLine("thats even");
            else
                Console.WriteLine("thats a odd");
        }
        public static bool PosOrNeg(int a)
        {
            if(a>0)
            { return true; }
            else
                { return false; }
        }
        public static void OldEnough(int a)
        {
            if (a > 18)
            { Console.WriteLine("You can vote"); }
            else
            { Console.WriteLine("Not yet"); }
        
        }

    }
}
