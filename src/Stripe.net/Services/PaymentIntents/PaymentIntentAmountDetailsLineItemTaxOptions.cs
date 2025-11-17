// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentIntentAmountDetailsLineItemTaxOptions : INestedOptions
    {
        /// <summary>
        /// The total amount of tax on a single line item represented in the <a
        /// href="https://stripe.com/docs/currencies#zero-decimal">smallest currency unit</a>.
        /// Required for L3 rates. An integer greater than or equal to 0.
        ///
        /// This field is mutually exclusive with the <c>amount_details[tax][total_tax_amount]</c>
        /// field.
        /// </summary>
        [JsonProperty("total_tax_amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("total_tax_amount")]
#endif
        public long? TotalTaxAmount { get; set; }
    }
}
