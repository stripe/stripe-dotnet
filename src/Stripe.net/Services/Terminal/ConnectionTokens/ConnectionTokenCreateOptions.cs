namespace Stripe.Terminal
{
    using Newtonsoft.Json;

    public class ConnectionTokenCreateOptions : BaseOptions
    {
        [JsonProperty("operator_account")]
        public string OperatorAccount { get; set; }
    }
}
