// File generated from our OpenAPI spec
namespace Stripe.Tax
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class TransactionShippingCostOptions : INestedOptions
    {
        /// <summary>
        /// The amount to reverse, in the <a
        /// href="https://docs.stripe.com/currencies#minor-units">smallest currency unit</a> in
        /// negative.
        /// </summary>
        [JsonProperty("amount")]
        [STJS.JsonPropertyName("amount")]
        public long? Amount { get; set; }

        /// <summary>
        /// The amount of tax to reverse, in the <a
        /// href="https://docs.stripe.com/currencies#minor-units">smallest currency unit</a> in
        /// negative.
        /// </summary>
        [JsonProperty("amount_tax")]
        [STJS.JsonPropertyName("amount_tax")]
        public long? AmountTax { get; set; }
    }
}
