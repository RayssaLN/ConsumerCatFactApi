using System;
using System.Net.Http;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ConsumerCatFactApi
{
    public class CatFact
    {
        [JsonPropertyName("fact")]
        public string Fact { get; set; } = string.Empty; // Inicializado para remover o aviso CS8618

        [JsonPropertyName("length")]
        public int Length { get; set; }
    }

    class Program
    {
        static async Task Main(string[] args)
        {
            string url = "https://catfact.ninja/fact";

            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync(url);
                    response.EnsureSuccessStatusCode();

                    // Correção do erro CS1061: adicionado o ponto em response.Content.ReadAsStringAsync()
                    string jsonString = await response.Content.ReadAsStringAsync();

                    // Correção dos avisos de valor nulo (CS8600 e CS8602)
                    CatFact? catFact = JsonSerializer.Deserialize<CatFact>(jsonString);

                    if (catFact != null)
                    {
                        Console.WriteLine("--- Fato sobre Gatos ---");
                        Console.WriteLine($"Fato: {catFact.Fact}");
                        Console.WriteLine($"Tamanho: {catFact.Length} caracteres");
                    }
                    else
                    {
                        Console.WriteLine("Não foi possível ler os dados do gato.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Erro ao consumir a API: {ex.Message}");
                }
            }
        }
    }
}