// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class InvoiceParentBillingCadenceDetails : StripeEntity<InvoiceParentBillingCadenceDetails>
    {
        /// <summary>
        /// The billing cadence that generated this invoice.
        /// </summary>
        [JsonProperty("billing_cadence")]
        [STJS.JsonPropertyName("billing_cadence")]
        public string BillingCadence { get; set; }
    }
}
