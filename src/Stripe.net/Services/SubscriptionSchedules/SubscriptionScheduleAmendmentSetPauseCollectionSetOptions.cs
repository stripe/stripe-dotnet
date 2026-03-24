// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class SubscriptionScheduleAmendmentSetPauseCollectionSetOptions : INestedOptions
    {
        /// <summary>
        /// The payment collection behavior for this subscription while paused. One of
        /// <c>keep_as_draft</c>, <c>mark_uncollectible</c>, or <c>void</c>.
        /// One of: <c>keep_as_draft</c>, <c>mark_uncollectible</c>, or <c>void</c>.
        /// </summary>
        [JsonProperty("behavior")]
        [STJS.JsonPropertyName("behavior")]
        public string Behavior { get; set; }
    }
}
