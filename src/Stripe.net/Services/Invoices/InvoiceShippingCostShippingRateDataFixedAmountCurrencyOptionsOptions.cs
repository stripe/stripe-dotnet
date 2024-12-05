// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class InvoiceShippingCostShippingRateDataFixedAmountCurrencyOptionsOptions : INestedOptions
    {
        /// <summary>
        /// A non-negative integer in cents representing how much to charge.
        /// </summary>
        [JsonProperty("amount")]
        public long? Amount { get; set; }

        /// <summary>
        /// Specifies whether the rate is considered inclusive of taxes or exclusive of taxes. One
        /// of <c>inclusive</c>, <c>exclusive</c>, or <c>unspecified</c>.
        /// One of: <c>exclusive</c>, <c>inclusive</c>, or <c>unspecified</c>.
        /// </summary>
        [JsonProperty("tax_behavior")]
        public string TaxBehavior { get; set; }
    }
}
