// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentIntentAmountDetailsTax : StripeEntity<PaymentIntentAmountDetailsTax>
    {
        /// <summary>
        /// Total portion of the amount that is for tax.
        /// </summary>
        [JsonProperty("total_tax_amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("total_tax_amount")]
#endif
        public long? TotalTaxAmount { get; set; }
    }
}
