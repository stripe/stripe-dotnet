namespace Stripe
{
    using Newtonsoft.Json;

    public class SetupIntentGetOptions : BaseOptions
    {
        [JsonProperty("client_secret")]
        public string ClientSecret { get; set; }
    }
}
