namespace Stripe
{
    using Newtonsoft.Json;

    public class ChargeTransferDataOptions : INestedOptions
    {
        [JsonProperty("destination")]
        public string Destination { get; set; }
    }
}
