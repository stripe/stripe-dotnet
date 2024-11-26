// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class SubscriptionCancellationDetails : StripeEntity<SubscriptionCancellationDetails>
    {
        /// <summary>
        /// Additional comments about why the user canceled the subscription, if the subscription
        /// was canceled explicitly by the user.
        /// </summary>
        [JsonProperty("comment")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("comment")]
#endif
        public string Comment { get; set; }

        /// <summary>
        /// The customer submitted reason for why they canceled, if the subscription was canceled
        /// explicitly by the user.
        /// One of: <c>customer_service</c>, <c>low_quality</c>, <c>missing_features</c>,
        /// <c>other</c>, <c>switched_service</c>, <c>too_complex</c>, <c>too_expensive</c>, or
        /// <c>unused</c>.
        /// </summary>
        [JsonProperty("feedback")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("feedback")]
#endif
        public string Feedback { get; set; }

        /// <summary>
        /// Why this subscription was canceled.
        /// One of: <c>cancellation_requested</c>, <c>payment_disputed</c>, or
        /// <c>payment_failed</c>.
        /// </summary>
        [JsonProperty("reason")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("reason")]
#endif
        public string Reason { get; set; }
    }
}
