namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentIntentGetOptions : BaseOptions
    {
        [JsonProperty("client_secret")]
        public string ClientSecret { get; set; }
    }
}
