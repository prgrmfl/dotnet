namespace HackYourFuture.DotnetMasterclass.Exercises
{
    public class Exercise1
    {
        // Write a method that asks the user to input 2 numbers and to return the biggest one
        public static void PrintTheLargestNumber()
        {
            Console.WriteLine("Hello there, please enter 2 numbers.");
            Console.Write("First number: ");
            var firstNumberText = Console.ReadLine();

            int firstNumber;
            while (!int.TryParse(firstNumberText, out firstNumber))
            {
                Console.Write("Invalid number. Please enter a valid number: ");
                firstNumberText = Console.ReadLine();
            }

            Console.Write("Second number: ");
            var secondNumberText = Console.ReadLine();

            int secondNumber;
            while (!int.TryParse(secondNumberText, out secondNumber))
            {
                Console.Write("Invalid number. Please enter a valid number: ");
                secondNumberText = Console.ReadLine();
            }

            var biggestNumber = firstNumber > secondNumber ? firstNumber : secondNumber;
            Console.WriteLine($"The biggest number is: {biggestNumber}");
            Console.ReadLine();
        }


        // Since there is a lot of duplicate code in the first solution above I refactored (= rewrite in an improved way) the code:
        public static void PrintTheLargestNumberRefactored()
        {
            Console.WriteLine("Hello there, please enter 2 numbers.");

            int firstNumber = AskUserANumber();
            var secondNumber = AskUserANumber();

            var biggestNumber = firstNumber > secondNumber ? firstNumber : secondNumber;
            Console.WriteLine($"The biggest number is: {biggestNumber}");
            Console.ReadLine();

        }
        // The duplicate code was moved into a separate method and made more generic:
        private static int AskUserANumber()
        {
            Console.Write($"Enter number: ");
            var numberText = Console.ReadLine();

            int number;
            while (!int.TryParse(numberText, out number))
            {
                Console.Write("Invalid number. Please enter a valid number: ");
                numberText = Console.ReadLine();
            }

            return number;
        }
    }
}
