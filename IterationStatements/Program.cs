namespace IterationStatements
{
    public class Program
    {
        static void Main(string[] args)
        {
            ManyNumbers();
            ByThree();
            Console.WriteLine(AreEqual(4, 4));
            IsEven(4);
            PosNeg();
            Voter();
            Range();
            MultTable(5);
        }
        //LukeWarm Section: Create methods below
        //Write a method that will print to the console all numbers 1000 through - 1000
        public static void ManyNumbers()
        {
            for (int a = -1000; a <= 1000; a++)
            {
                Console.WriteLine(a);
            }
        }
        //Write a method that will print to the console numbers 3 through 999 by 3 each time
        public static void ByThree()
        {
            for (int b = 3; b <= 999; b += 3)
            {
                Console.WriteLine(b);
            }

        }

        //Write a method to accept two integers as parameterss and check whether they are equal or not
        public static bool AreEqual(int num1, int num2)

        {
            if (num1 == num2)
            {
                return true;
            }
            else
            { 
                return false; 
            }
        }

       
          

        //Write a method to check whether a given number is even or odd

        public static void IsEven(int num)
        {
            if (num % 2 == 0)
            {
                Console.WriteLine($"{num} is an even number.");
            }
            else
            {
                Console.WriteLine($"{num} is an odd number.");

            }
        }


        //Write a method to check whether a given number is positive or negative

        public static void PosNeg()
        {
            Console.WriteLine("Give me a number and I'll tell you if it's possitive or negative");
            var userInput = int.Parse(Console.ReadLine());
          
            if (userInput > 0)
            {
                Console.WriteLine($"{userInput} is a positive number");
            }
            else
            {
                Console.WriteLine($"{userInput} is a negative number");

            }

        }


        //Write a method to read the age of a candidate and determine whether they can vote.
        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()
        public static void Voter()
        {
            Console.WriteLine("Welcome to the polls, what is your age?");
            var userInput = int.Parse(Console.ReadLine());

            if (userInput < 18)
            {
                Console.WriteLine($"Sorry {userInput} is too young to vote.");
            }
            else
                Console.WriteLine("Okay, here is your voting sheet.");


        }



        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10
        public static void Range()
        {
            Console.WriteLine("Give me a number, I'll tell you if it's between -10 and 10");
            var userInput = int.Parse(Console.ReadLine());

            if (userInput >= -10 && userInput <= 10)
            {
                Console.WriteLine($"Yes, {userInput} is between -10 and 10");
            }
            else
            {
                Console.WriteLine($"No, {userInput} is out of that range");
            }


        }

        //Write a method to display the multiplication table(from 1 to 12) of a given integer

        public static void MultTable(int num)
        {
            Console.WriteLine($"Here is {num} multiplied 1 to 12 times:");


            for (int i = 1; i <= 12; i++)
            {
                int answer = num * 1;
                Console.WriteLine($"{num} * {i} = {answer}");
            }


            //Call the methods to test them in the Main method below
        }
    }
}
