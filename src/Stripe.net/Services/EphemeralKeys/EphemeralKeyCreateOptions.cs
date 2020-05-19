namespace Stripe
{
    using Newtonsoft.Json;

    public class EphemeralKeyCreateOptions : BaseOptions
    {
        [JsonProperty("customer")]
        public string Customer { get; set; }

        [JsonProperty("issuing_card")]
        public string IssuingCard { get; set; }
    }
}
