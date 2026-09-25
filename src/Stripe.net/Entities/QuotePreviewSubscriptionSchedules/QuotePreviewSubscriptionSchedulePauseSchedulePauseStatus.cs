// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class QuotePreviewSubscriptionSchedulePauseSchedulePauseStatus : StripeEntity<QuotePreviewSubscriptionSchedulePauseSchedulePauseStatus>
    {
        [JsonProperty("error")]
        [STJS.JsonPropertyName("error")]
        public QuotePreviewSubscriptionSchedulePauseSchedulePauseStatusError Error { get; set; }

        /// <summary>
        /// The lifecycle state of the pause operation.
        /// One of: <c>error</c>, <c>scheduled</c>, or <c>succeeded</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
