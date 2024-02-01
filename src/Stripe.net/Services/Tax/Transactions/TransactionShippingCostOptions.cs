// File generated from our OpenAPI spec
namespace Stripe.Tax
{
    using Newtonsoft.Json;

    public class TransactionShippingCostOptions : INestedOptions
    {
        /// <summary>
        /// The amount to reverse, in the <a
        /// href="https://stripe.com/docs/currencies#zero-decimal">smallest currency unit</a> in
        /// negative.
        /// </summary>
        [JsonProperty("amount")]
        public long? Amount { get; set; }

        /// <summary>
        /// The amount of tax to reverse, in the <a
        /// href="https://stripe.com/docs/currencies#zero-decimal">smallest currency unit</a> in
        /// negative.
        /// </summary>
        [JsonProperty("amount_tax")]
        public long? AmountTax { get; set; }
    }
}
