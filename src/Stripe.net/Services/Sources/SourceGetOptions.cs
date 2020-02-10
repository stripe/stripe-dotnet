namespace Stripe
{
    using Newtonsoft.Json;

    public class SourceGetOptions : BaseOptions
    {
        [JsonProperty("client_secret")]
        public string ClientSecret { get; set; }
    }
}
