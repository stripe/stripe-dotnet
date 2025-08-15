// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class CadenceInvoiceDiscountRulePercentOffMaximumApplications : StripeEntity<CadenceInvoiceDiscountRulePercentOffMaximumApplications>
    {
        /// <summary>
        /// Max applications type of this discount, ex: indefinite.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }
    }
}
