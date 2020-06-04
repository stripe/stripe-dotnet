namespace Stripe.Terminal
{
    using Newtonsoft.Json;

    public class ConnectionTokenCreateOptions : BaseOptions
    {
        [JsonProperty("location")]
        public string Location { get; set; }
    }
}
