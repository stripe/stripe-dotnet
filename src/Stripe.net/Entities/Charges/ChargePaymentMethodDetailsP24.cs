namespace Stripe
{
    using Newtonsoft.Json;

    public class ChargePaymentMethodDetailsP24 : StripeEntity<ChargePaymentMethodDetailsP24>
    {
        /// <summary>
        /// Unique reference for this Przelewy24 payment.
        /// </summary>
        [JsonProperty("reference")]
        public string Reference { get; set; }

        /// <summary>
        /// Owner's verified full name. Values are verified or provided by Przelewy24 directly (if
        /// supported) at the time of authorization or settlement. They cannot be set or mutated.
        /// Przelewy24 rarely provides this information so the attribute is usually empty.
        /// </summary>
        [JsonProperty("verified_name")]
        public string VerifiedName { get; set; }
    }
}
