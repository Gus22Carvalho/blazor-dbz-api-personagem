using System.Text.Json.Serialization;

namespace BlazorPersonagemDragonBall.Models
{
    public class Personagem
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string? Nome { get; set; }

        [JsonPropertyName("ki")]
        public string? Ki { get; set; }

        [JsonPropertyName("maxKi")]
        public string? KiMaximo { get; set; }

        [JsonPropertyName("race")]
        public string? Raca { get; set; }

        [JsonPropertyName("gender")]
        public string? Genero { get; set; }

        [JsonPropertyName("description")]
        public string? Descricao { get; set; }

        [JsonPropertyName("image")]
        public string? Imagem { get; set; }

        [JsonPropertyName("affiliation")]
        public string? Afiliacao { get; set; }

        [JsonPropertyName("deletedAt")]
        public DateTime? DeletadoEm { get; set; }

        [JsonPropertyName("originPlanet")]
        public Planeta? PlanetaOrigem { get; set; }

        [JsonPropertyName("transformations")]
        public List<Transformacao> Transformacoes { get; set; } = new();
    }

    public class Planeta
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string? Nome { get; set; }

        [JsonPropertyName("isDestroyed")]
        public bool Destruido { get; set; }

        [JsonPropertyName("description")]
        public string? Descricao { get; set; }

        [JsonPropertyName("image")]
        public string? Imagem { get; set; }

        [JsonPropertyName("deletedAt")]
        public DateTime? DeletadoEm { get; set; }
    }

    public class Transformacao
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        public string? Nome { get; set; }

        [JsonPropertyName("image")]
        public string? Imagem { get; set; }

        [JsonPropertyName("ki")]
        public string? Ki { get; set; }

        [JsonPropertyName("deletedAt")]
        public DateTime? DeletadoEm { get; set; }
    }
}
