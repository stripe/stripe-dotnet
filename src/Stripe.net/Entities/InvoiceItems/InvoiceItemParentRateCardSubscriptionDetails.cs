// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class InvoiceItemParentRateCardSubscriptionDetails : StripeEntity<InvoiceItemParentRateCardSubscriptionDetails>
    {
        /// <summary>
        /// The rate card subscription that generated this invoice item.
        /// </summary>
        [JsonProperty("rate_card_subscription")]
        [STJS.JsonPropertyName("rate_card_subscription")]
        public string RateCardSubscription { get; set; }

        /// <summary>
        /// The rate card version that generated this invoice item.
        /// </summary>
        [JsonProperty("rate_card_version")]
        [STJS.JsonPropertyName("rate_card_version")]
        public string RateCardVersion { get; set; }
    }
}
