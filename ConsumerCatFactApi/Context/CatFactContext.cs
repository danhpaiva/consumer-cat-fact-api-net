using System.Text.Json.Serialization;
using ConsumerCatFactApi.Models;

namespace ConsumerCatFactApi.Context;

// Otimização de JSON no .NET (Source Generator)
[JsonSerializable(typeof(CatFact))]
internal partial class CatFactContext : JsonSerializerContext
{
}
