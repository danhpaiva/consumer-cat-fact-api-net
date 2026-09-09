using System.Text.Json.Serialization;

namespace ConsumerCatFactApi.Models;

// Representação do JSON retornado pela API
public record CatFact(
    [property: JsonPropertyName("fact")] string Fact,
    [property: JsonPropertyName("length")] int Length
);
