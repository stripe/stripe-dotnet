// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class InvoiceLineItemParentRateCardSubscriptionDetails : StripeEntity<InvoiceLineItemParentRateCardSubscriptionDetails>
    {
        /// <summary>
        /// The invoice item that generated this line item.
        /// </summary>
        [JsonProperty("invoice_item")]
        [STJS.JsonPropertyName("invoice_item")]
        public string InvoiceItem { get; set; }

        /// <summary>
        /// The rate card subscription that generated this line item.
        /// </summary>
        [JsonProperty("rate_card_subscription")]
        [STJS.JsonPropertyName("rate_card_subscription")]
        public string RateCardSubscription { get; set; }

        /// <summary>
        /// The rate card version at the time this line item was generated.
        /// </summary>
        [JsonProperty("rate_card_version")]
        [STJS.JsonPropertyName("rate_card_version")]
        public string RateCardVersion { get; set; }
    }
}
