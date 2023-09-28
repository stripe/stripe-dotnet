// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class MandateSingleUse : StripeEntity<MandateSingleUse>
    {
        /// <summary>
        /// The amount of the payment on a single use mandate.
        /// </summary>
        [JsonProperty("amount")]
        public long Amount { get; set; }

        /// <summary>
        /// The currency of the payment on a single use mandate.
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }
    }
}
