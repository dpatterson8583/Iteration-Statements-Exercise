namespace IterationStatements
{
    public class Program
    {
        //LukeWarm Section: Create methods below
        //Write a method that will print to the console all numbers 1000 through - 1000

        public static void Print2000()
        { 
            for(int i = 1000;i>=-2000;i--)
            {
                Console.WriteLine(i);
            }
        }

        //Write a method that will print to the console numbers 3 through 999 by 3 each time
        public static void PrintBy3()
        {
            for (int i = 3; i <= 999; i+=3)
            {
                Console.WriteLine(i);
            }
        }

        //Write a method to accept two integers as parameterss and check whether they are equal or not
        public static bool AreWeEqual(int i, int j) 
        {
            Console.WriteLine("Are these two integers equal?");
            return i==j;
        }

        //Write a method to check whether a given number is even or odd
        public static string EvenOrOdd(int ii)
        {
            if(ii % 2 == 0)
            {
                return "Even";
            }
            else { 
                return "Odd"; 
            }
            
        }

        //Write a method to check whether a given number is positive or negative
        public static string PositiveOrNegative(int ii)
        {
            if (ii>0)
            {
                return "Positive";
            }
            else if (ii<0)
            {
                return "Negative";
            }
            else
            { return "Zero which is neither positive or negative"; }

        }

        //Write a method to read the age of a candidate and determine whether they can vote.
        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()
        public static bool AgeChecker()
        {
            int age = Convert.ToInt32(Console.ReadLine());
            return age >= 18;
        }

        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10
        public static bool InRange()
        { 
            int val = Convert.ToInt32(Console.ReadLine());
            return val >= -10 && val <= 10;
        }

        //Write a method to display the multiplication table(from 1 to 12) of a given integer
        public static void DrawMultiplicationTable()
        {
            for (int j = 1; j <= 12; j++) 
            { 
                for (int i = 1; i <= 12; i++)
                {
                    Console.Write(i*j);
                    if (i * j > 9)
                    {
                        Console.Write("    ");
                    }
                    else if (i * j < 10)
                    {
                        Console.Write("    ");
                    }
                    else if (i*j>99)
                    {
                        Console.Write("");
                    }
                    
                    if (i == 12) { Console.WriteLine(); }

                }
            }
        }

        //Call the methods to test them in the Main method below
        static void Main(string[] args)
        {
            Print2000();

            Console.WriteLine("----------------------Press to Continue");
            Console.ReadLine();

            PrintBy3();

            Console.WriteLine("----------------------Press to Continue");
            Console.ReadLine();

            Console.WriteLine(AreWeEqual(5, 6));

            Console.WriteLine("----------------------Press to Continue");
            Console.ReadLine();

            Console.WriteLine(EvenOrOdd(5));

            Console.WriteLine("----------------------Press to Continue");
            Console.ReadLine();

            Console.WriteLine(PositiveOrNegative(10));

            Console.WriteLine("----------------------Press to Continue");
            Console.ReadLine();

            Console.Write($"How old are you? > ");
            Console.WriteLine(AgeChecker());

            Console.WriteLine("----------------------Press to Continue");
            Console.ReadLine();

            Console.Write("Give me a number between -10 and 10 >");
            Console.WriteLine(InRange());

            Console.WriteLine("----------------------Press to Continue");
            Console.ReadLine();

            DrawMultiplicationTable();

            Console.WriteLine("----------------------Press to Continue");
            Console.ReadLine();
        }
        

    }
}
