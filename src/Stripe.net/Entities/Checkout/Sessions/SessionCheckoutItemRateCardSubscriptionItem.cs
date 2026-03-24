// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class SessionCheckoutItemRateCardSubscriptionItem : StripeEntity<SessionCheckoutItemRateCardSubscriptionItem>, IHasMetadata
    {
        [JsonProperty("rate_card")]
        [STJS.JsonPropertyName("rate_card")]
        public string RateCard { get; set; }

        [JsonProperty("metadata")]
        [STJS.JsonPropertyName("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [JsonProperty("rate_card_version")]
        [STJS.JsonPropertyName("rate_card_version")]
        public string RateCardVersion { get; set; }

        [JsonProperty("billing_cadence")]
        [STJS.JsonPropertyName("billing_cadence")]
        public string BillingCadence { get; set; }

        [JsonProperty("rate_card_subscription")]
        [STJS.JsonPropertyName("rate_card_subscription")]
        public string RateCardSubscription { get; set; }
    }
}
