// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PaymentPlanCollectsOn : StripeEntity<PaymentPlanCollectsOn>
    {
        [JsonProperty("invoice_details")]
        [STJS.JsonPropertyName("invoice_details")]
        public PaymentPlanCollectsOnInvoiceDetails InvoiceDetails { get; set; }

        /// <summary>
        /// The type of object this plan collects against. Currently always <c>invoice_details</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
