// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PaymentPlanCollectsOnInvoiceDetails : StripeEntity<PaymentPlanCollectsOnInvoiceDetails>
    {
        /// <summary>
        /// The ID of the invoice this plan collects against.
        /// </summary>
        [JsonProperty("invoice")]
        [STJS.JsonPropertyName("invoice")]
        public string Invoice { get; set; }
    }
}
