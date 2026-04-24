// File generated from our OpenAPI spec
namespace Stripe.V2.Payments
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class OffSessionPaymentCreateAmountDetailsTaxOptions : INestedOptions
    {
        /// <summary>
        /// Total portion of the amount that is for tax.
        /// </summary>
        [JsonProperty("total_tax_amount")]
        [STJS.JsonPropertyName("total_tax_amount")]
        public long? TotalTaxAmount { get; set; }
    }
}
