using System.Text.Json.Serialization;

namespace BrazilUniversities.Responses
{
    public class University
    {
        [JsonPropertyName("country")]
        public string? Country { get; set; }

        [JsonPropertyName("state-province")]
        public object? StateProvince { get; set; }

        [JsonPropertyName("web_pages")]
        public List<string?>? WebPages { get; set; }

        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("domains")]
        public List<string?>? Domains { get; set; }

        [JsonPropertyName("alpha_two_code")]
        public string? AlphaTwoCode { get; set; }
    }
}
