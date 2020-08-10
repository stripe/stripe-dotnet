namespace Stripe
{
    using Newtonsoft.Json;

    public class MandateSingleUse : StripeEntity<MandateSingleUse>
    {
        [JsonProperty("amount")]
        public long Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }
}
