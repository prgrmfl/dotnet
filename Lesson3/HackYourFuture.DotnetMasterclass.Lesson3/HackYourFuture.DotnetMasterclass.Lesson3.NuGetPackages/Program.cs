using Flurl.Http;

namespace HackYourFuture.DotnetMasterclass.Lesson3.NuGetPackages
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var ditto = await "https://pokeapi.co/api/v2/pokemon/ditto".GetJsonAsync<Pokemon>();
            Console.WriteLine($"Ditto weighs {ditto.weight} kg");
            Console.ReadLine();

            var newEx = new Exercise1();
            newEx.PrintTimestampsInHumanReadableFormat();
            //Exercise1.PrintTimestampsInHumanReadableFormat(); // if you use static method, then you can use directly class.
            // It is bad practice to use public static variables
            
            
            
        }
    }
}