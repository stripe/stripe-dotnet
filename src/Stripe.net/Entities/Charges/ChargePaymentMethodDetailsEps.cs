namespace Stripe
{
    using Newtonsoft.Json;

    public class ChargePaymentMethodDetailsEps : StripeEntity<ChargePaymentMethodDetailsEps>
    {
        /// <summary>
        /// Owner's verified full name. Values are verified or provided by EPS directly (if
        /// supported) at the time of authorization or settlement. They cannot be set or mutated.
        /// EPS rarely provides this information so the attribute is usually empty.
        /// </summary>
        [JsonProperty("verified_name")]
        public string VerifiedName { get; set; }
    }
}
