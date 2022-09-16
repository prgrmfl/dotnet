namespace HackYourFuture.DotnetMasterclass.Exercises
{
    public class Exercise7
    {
        // Write a method that returns the sum of two numbers divided by 3. Create a separate method with the math logic.
        public static void AddTwoNumbersAndDivideBy3()
        {
            Console.WriteLine("Hello there, please enter 2 numbers.");

            var firstNumber = AskUserANumber();
            var secondNumber = AskUserANumber();

            Console.WriteLine($"The result is: {(firstNumber + secondNumber) / 3}");
            Console.ReadLine();

        }
        private static double AskUserANumber()
        {
            Console.Write($"Enter number: ");
            var numberText = Console.ReadLine();

            double number;
            while (!double.TryParse(numberText, out number))
            {
                Console.Write("Invalid number. Please enter a valid number: ");
                numberText = Console.ReadLine();
            }

            return number;
        }
    }
}