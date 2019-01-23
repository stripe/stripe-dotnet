namespace Stripe
{
    using Newtonsoft.Json;

    public class DeclineChargeOn : StripeEntity<DeclineChargeOn>
    {
        [JsonProperty("avs_failure")]
        public bool AvsFailure { get; set; }

        [JsonProperty("cvc_failure")]
        public bool CvcFailure { get; set; }
    }
}
