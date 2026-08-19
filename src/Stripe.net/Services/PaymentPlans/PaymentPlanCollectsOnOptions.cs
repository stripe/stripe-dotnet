// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class PaymentPlanCollectsOnOptions : INestedOptions
    {
        /// <summary>
        /// Details of the invoice this payment plan collects on.
        /// </summary>
        [JsonProperty("invoice_details")]
        [STJS.JsonPropertyName("invoice_details")]
        public PaymentPlanCollectsOnInvoiceDetailsOptions InvoiceDetails { get; set; }

        /// <summary>
        /// The type of object this plan collects on. Currently always <c>invoice_details</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
