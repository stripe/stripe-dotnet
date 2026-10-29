// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class SubscriptionItemCurrentTrial : StripeEntity<SubscriptionItemCurrentTrial>
    {
        /// <summary>
        /// The time the current trial ends.
        /// </summary>
        [JsonProperty("end_date")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("end_date")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime EndDate { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// The time the current trial started.
        /// </summary>
        [JsonProperty("start_date")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("start_date")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime StartDate { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// The Trial Offer ID applied to the subscription item.
        /// </summary>
        [JsonProperty("trial_offer")]
        [STJS.JsonPropertyName("trial_offer")]
        public string TrialOffer { get; set; }
    }
}
