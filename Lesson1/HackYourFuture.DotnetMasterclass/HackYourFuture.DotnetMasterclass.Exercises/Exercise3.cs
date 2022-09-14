namespace HackYourFuture.DotnetMasterclass.Exercises
{
    public class Exercise3
    {
        // Write a method to create a new string from a given string where the first and last characters will change their positions
        // E.g.: programming => grogramminp
        public static void ReverseFirstAndLastLettersInWord()
        {
            // The question mark behin the word string means that this is a nullable type
            // Read more here: https://docs.microsoft.com/en-us/dotnet/csharp/nullable-references
            string? word = null;
            while (word == null || word.Length < 2)
            {
                Console.WriteLine("Enter a word with at least two letters: ");
                word = Console.ReadLine();
            }

            // There is a combination here of a built in String function "Substring" and LINQ functions "Last" and "First" which are available on collections
            // That makes clear that a String is a collection of chars (IEnumerable<char>)
            // Put your cursor on the type string and press F12 to go to the definition (alternatively hold CTRL + Left mouse button click)
            Console.WriteLine($"{word.Last()}{word.Substring(1, word.Length - 2)}{word.First()}");
            Console.ReadLine();
        }
    }
}