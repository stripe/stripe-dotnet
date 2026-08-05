// File generated from our OpenAPI spec
namespace Stripe.Billing
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class FeedbackOptionsStatusTransitions : StripeEntity<FeedbackOptionsStatusTransitions>
    {
        /// <summary>
        /// The time the feedback option was deactivated, if any. Measured in seconds since Unix
        /// epoch.
        /// </summary>
        [JsonProperty("deactivated_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("deactivated_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime? DeactivatedAt { get; set; }
    }
}
