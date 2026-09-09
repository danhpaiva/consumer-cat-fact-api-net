using System.Net.Http.Json;
using System.Text.Json.Serialization;
using ConsumerCatFactApi.Context;

using var client = new HttpClient();

try
{
    Console.WriteLine("\nBuscando um fato sobre gatos...\n");
    var catFact = await client.GetFromJsonAsync("https://catfact.ninja/fact", CatFactContext.Default.CatFact);

    if (catFact is not null)
    {
        Console.WriteLine($"\nFact: {catFact.Fact}");
        Console.WriteLine($"\nLength: {catFact.Length}");
    }
}
catch (Exception ex)
{
    Console.WriteLine($"\nErro ao consultar a API: {ex.Message}");
}



