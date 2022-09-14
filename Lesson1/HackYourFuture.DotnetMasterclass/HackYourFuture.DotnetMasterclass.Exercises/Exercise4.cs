using System.ComponentModel;

namespace HackYourFuture.DotnetMasterclass.Exercises
{
    public class Exercise4
    {
        // Write a method to check if a given string contains two similar consecutive letters
        // Banana => No consecutive letters found
        // Apple => !!! Found consecutive letter 'p'
        // Cappuccino => !!! Found consecutive letters 'p' and 'c'
        public static void CheckIfWordHasTwoSimilarConsecutiveLetters()
        {
            string? word = null;
            while (word == null)
            {
                Console.WriteLine("Please enter a word: ");
                word = Console.ReadLine();
            }

            var similarConsecutiveLetters = GetSimilarConsecutiveLetters(word);
            Console.WriteLine($"Found the following similar consecutive letters: {string.Join(", ", similarConsecutiveLetters)}");
            Console.ReadLine();
        }

        private static List<char> GetSimilarConsecutiveLetters(string word)
        {
            var similarConsecutiveLetters = new List<char>();

            for (int i = 1; i < word.Length; i++)
            {
                if (word[i - 1] == word[i])
                {
                    similarConsecutiveLetters.Add(word[i]);
                }
            }

            return similarConsecutiveLetters;
        }
    }
}