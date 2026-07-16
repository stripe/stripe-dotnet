// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class QuotePreviewSubscriptionSchedulePauseSchedulePause : StripeEntity<QuotePreviewSubscriptionSchedulePauseSchedulePause>
    {
        /// <summary>
        /// Time at which the subscription pauses.
        /// </summary>
        [JsonProperty("pause_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("pause_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime PauseAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Settings controlling billing behavior during the pause.
        /// </summary>
        [JsonProperty("settings")]
        [STJS.JsonPropertyName("settings")]
        public QuotePreviewSubscriptionSchedulePauseSchedulePauseSettings Settings { get; set; }
    }
}
