// File generated from our OpenAPI spec
namespace Stripe.Tax
{
    using Newtonsoft.Json;

    public class TransactionShippingCostOptions : INestedOptions
    {
        /// <summary>
        /// The amount to reverse, in negative integer cents.
        /// </summary>
        [JsonProperty("amount")]
        public long? Amount { get; set; }

        /// <summary>
        /// The amount of tax to reverse, in negative integer cents.
        /// </summary>
        [JsonProperty("amount_tax")]
        public long? AmountTax { get; set; }
    }
}
