namespace Stripe
{
    using Newtonsoft.Json;

    public class MandateSingleUse : StripeEntity<MandateSingleUse>
    {
        /// <summary>
        /// On a single use mandate, the amount of the payment.
        /// </summary>
        [JsonProperty("amount")]
        public long Amount { get; set; }

        /// <summary>
        /// On a single use mandate, the currency of the payment.
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }
    }
}
