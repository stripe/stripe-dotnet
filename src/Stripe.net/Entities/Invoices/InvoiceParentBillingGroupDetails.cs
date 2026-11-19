// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class InvoiceParentBillingGroupDetails : StripeEntity<InvoiceParentBillingGroupDetails>
    {
        /// <summary>
        /// The billing group that generated this invoice.
        /// </summary>
        [JsonProperty("billing_group")]
        [STJS.JsonPropertyName("billing_group")]
        public string BillingGroup { get; set; }
    }
}
