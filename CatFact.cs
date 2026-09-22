using System.Text.Json.Serialization;

public class CatFact
{
    [JsonPropertyName("fact")]
    public string Fact { get; set; }

    [JsonPropertyName("length")]
    public int Length { get; set; }
}