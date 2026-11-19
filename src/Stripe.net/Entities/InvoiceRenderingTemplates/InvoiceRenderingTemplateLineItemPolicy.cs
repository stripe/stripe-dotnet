// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class InvoiceRenderingTemplateLineItemPolicy : StripeEntity<InvoiceRenderingTemplateLineItemPolicy>
    {
        /// <summary>
        /// A CEL expression that takes in a line item and returns a string indicating whether the
        /// line item should be 'hidden_if_zero' or 'visible'. If 'hidden_if_zero', the line item
        /// will be hidden if the line item's amount is zero on the invoice. If 'visible', the line
        /// item will be shown regardless of the line item's amount.
        /// </summary>
        [JsonProperty("display")]
        [STJS.JsonPropertyName("display")]
        public string Display { get; set; }
    }
}
