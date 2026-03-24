// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class SubscriptionSchedulePhaseItemDiscountDiscountEnd : StripeEntity<SubscriptionSchedulePhaseItemDiscountDiscountEnd>
    {
        /// <summary>
        /// The discount end timestamp.
        /// </summary>
        [JsonProperty("timestamp")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("timestamp")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime? Timestamp { get; set; }

        /// <summary>
        /// The discount end type.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
