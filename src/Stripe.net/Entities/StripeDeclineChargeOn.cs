namespace Stripe
{
    using Newtonsoft.Json;

    public class StripeDeclineChargeOn : StripeEntity
    {
        [JsonProperty("avs_failure")]
        public bool AvsFailure { get; set; }

        [JsonProperty("cvc_failure")]
        public bool CvcFailure { get; set; }
    }
}