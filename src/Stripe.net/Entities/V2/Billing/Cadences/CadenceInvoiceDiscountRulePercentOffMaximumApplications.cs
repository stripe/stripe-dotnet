// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class CadenceInvoiceDiscountRulePercentOffMaximumApplications : StripeEntity<CadenceInvoiceDiscountRulePercentOffMaximumApplications>
    {
        /// <summary>
        /// Max applications type of this discount, ex: indefinite.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
