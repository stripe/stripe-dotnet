namespace Stripe
{
    using Newtonsoft.Json;

    public class TokenPiiOptions : INestedOptions
    {
        [JsonProperty("id_number")]
        public string IdNumber { get; set; }
    }
}
