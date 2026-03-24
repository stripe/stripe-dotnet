// File generated from our OpenAPI spec
namespace Stripe.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AlertSpendThresholdGteAmountOptions : INestedOptions
    {
        /// <summary>
        /// Three-letter <a href="https://stripe.com/docs/currencies">ISO code for the currency</a>
        /// of the <c>value</c> parameter.
        /// </summary>
        [JsonProperty("currency")]
        [STJS.JsonPropertyName("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// An integer representing the amount of the threshold.
        /// </summary>
        [JsonProperty("value")]
        [STJS.JsonPropertyName("value")]
        public long? Value { get; set; }
    }
}
