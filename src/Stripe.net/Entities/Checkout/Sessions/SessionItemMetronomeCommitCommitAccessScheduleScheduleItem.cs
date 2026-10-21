// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class SessionItemMetronomeCommitCommitAccessScheduleScheduleItem : StripeEntity<SessionItemMetronomeCommitCommitAccessScheduleScheduleItem>
    {
        /// <summary>
        /// The access amount in credit_type_id units.
        /// </summary>
        [JsonProperty("amount")]
        [JsonConverter(typeof(DecimalStringConverter))]
        [STJS.JsonNumberHandling(STJS.JsonNumberHandling.AllowReadingFromString | STJS.JsonNumberHandling.WriteAsString)]
        [STJS.JsonPropertyName("amount")]
        public decimal Amount { get; set; }

        /// <summary>
        /// Hour-aligned RFC 3339 timestamp in UTC at which access to the balance amount ends
        /// (exclusive).
        /// </summary>
        [JsonProperty("ending_before")]
        [STJS.JsonPropertyName("ending_before")]
        public string EndingBefore { get; set; }

        /// <summary>
        /// Hour-aligned RFC 3339 timestamp in UTC at which access to the balance amount starts
        /// (inclusive).
        /// </summary>
        [JsonProperty("starting_at")]
        [STJS.JsonPropertyName("starting_at")]
        public string StartingAt { get; set; }
    }
}
