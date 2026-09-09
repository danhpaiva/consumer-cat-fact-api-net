using System.Net.Http.Json;
using ConsumerCatFactApi.Models;

using var client = new HttpClient();

try
{
    Console.WriteLine("\nBuscando um fato sobre gatos...\n");

    var catFact = await client.GetFromJsonAsync<CatFact>("https://catfact.ninja/fact");

    if (catFact is not null)
    {
        Console.WriteLine($"Fact: {catFact.Fact}");
        Console.WriteLine($"Length: {catFact.Length}");
    }
}
catch (Exception ex)
{
    Console.WriteLine($"\nErro ao consultar a API: {ex.Message}");
}