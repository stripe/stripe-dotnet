// File generated from our OpenAPI spec
namespace Stripe.Tax
{
    using Newtonsoft.Json;

    public class CalculationShippingCostOptions : INestedOptions
    {
        /// <summary>
        /// A positive integer in the <a
        /// href="https://stripe.com/docs/currencies#zero-decimal">smallest currency unit</a>
        /// representing the shipping charge. If <c>tax_behavior=inclusive</c>, then this amount
        /// includes taxes. Otherwise, taxes are calculated on top of this amount.
        /// </summary>
        [JsonProperty("amount")]
        public long? Amount { get; set; }

        /// <summary>
        /// If provided, the <a href="https://stripe.com/docs/api/shipping_rates/object">shipping
        /// rate</a>'s <c>amount</c>, <c>tax_code</c> and <c>tax_behavior</c> are used. If you
        /// provide a shipping rate, then you cannot pass the <c>amount</c>, <c>tax_code</c>, or
        /// <c>tax_behavior</c> parameters.
        /// </summary>
        [JsonProperty("shipping_rate")]
        public string ShippingRate { get; set; }

        /// <summary>
        /// Specifies whether the <c>amount</c> includes taxes. If <c>tax_behavior=inclusive</c>,
        /// then the amount includes taxes. Defaults to <c>exclusive</c>.
        /// One of: <c>exclusive</c>, or <c>inclusive</c>.
        /// </summary>
        [JsonProperty("tax_behavior")]
        public string TaxBehavior { get; set; }

        /// <summary>
        /// The <a href="https://stripe.com/docs/tax/tax-categories">tax code</a> used to calculate
        /// tax on shipping. If not provided, the default shipping tax code from your <a
        /// href="https://stripe.com/settings/tax">Tax Settings</a> is used.
        /// </summary>
        [JsonProperty("tax_code")]
        public string TaxCode { get; set; }
    }
}
