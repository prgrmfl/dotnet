namespace HackYourFuture.DotnetMasterclass.Exercises
{
    internal class Exercise8
    {
        // Write a method to calculate the sum of the individual digits of a given number. Do this recursively until you have a single digit number. You will need a separate method with the logic.
        // 12345 => 15 => 6
        public static void AddDigitsForAGivenNumber()
        {
            Console.WriteLine("Hello there, please enter 2 numbers.");
            var number = AskUserANumber();

            while (number.ToString().Length > 1)
            {
                number = SimplifyNumber(number.ToString());
            }

            Console.WriteLine($"The simplified number is: {number}");
            Console.ReadLine();
        }
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

        private static int SimplifyNumber(string numberText)
        {
            int sum = 0;
            foreach (var digit in numberText)
            {
                // Be careful here not to take the numeric representation of a char. Behind the scenes every unicode char has an integer value: https://www.ssec.wisc.edu/~tomw/java/unicode.html
                sum += int.Parse(digit.ToString());
            }
            return sum;
        }
    }
}