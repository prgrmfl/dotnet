namespace HackYourFuture.DotnetMasterclass.Lesson3.AsyncAwait
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            // ask the user for poke name:
            Console.WriteLine("Please enter a name of a pokemon");
            var st = Console.ReadLine();
            while (st == null)
            {
                st = Console.ReadLine();
            }
            // run pokemon getter method
            var pokemon = await Exercise1.GetPokemon(st);
            Console.WriteLine(pokemon);

            Console.WriteLine(await GetPokemonDitto());
            Console.ReadLine();


            // Wait for multiple tasks
            var result = await Task.WhenAll(GetPokemonDitto(), GetPokemonCharmander());
            Console.WriteLine(result[0]);
            Console.WriteLine(result[1]);
            Console.ReadLine();
        }

        private static async Task<string> GetPokemonDitto()
        {
            var httpClient = new HttpClient();
            var result = await httpClient.GetAsync("https://pokeapi.co/api/v2/pokemon/ditto");

            return await result.Content.ReadAsStringAsync();
        }

        private static async Task<string> GetPokemonCharmander()
        {
            var httpClient = new HttpClient();
            var result = await httpClient.GetAsync("https://pokeapi.co/api/v2/pokemon/charmander");

            return await result.Content.ReadAsStringAsync();
        }
    }
}