// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class InvoiceItemParent : StripeEntity<InvoiceItemParent>
    {
        /// <summary>
        /// Details about the subscription that generated this invoice item.
        /// </summary>
        [JsonProperty("subscription_details")]
        [STJS.JsonPropertyName("subscription_details")]
        public InvoiceItemParentSubscriptionDetails SubscriptionDetails { get; set; }

        /// <summary>
        /// The type of parent that generated this invoice item.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
