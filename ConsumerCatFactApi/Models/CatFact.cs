using System.Text.Json.Serialization;

namespace ConsumerCatFactApi.Models;

public record CatFact(
    [property: JsonPropertyName("fact")] string Fact,
    [property: JsonPropertyName("length")] int Length
);
