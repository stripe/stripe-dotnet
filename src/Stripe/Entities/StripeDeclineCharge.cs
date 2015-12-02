using Newtonsoft.Json;

namespace Stripe
{
    public class StripeDeclineCharge
    {
        [JsonProperty("avs_failure")]
        public bool AvsFailure { get; set; }

        [JsonProperty("cvc_failure")]
        public bool CvcFailure { get; set; }
    }
}
