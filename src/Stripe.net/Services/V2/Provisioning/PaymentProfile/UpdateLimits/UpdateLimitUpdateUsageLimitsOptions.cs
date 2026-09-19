// File generated from our OpenAPI spec
namespace Stripe.V2.Provisioning.PaymentProfile
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class UpdateLimitUpdateUsageLimitsOptions : INestedOptions
    {
        /// <summary>
        /// Three-letter ISO currency code for <c>max_amount</c>.
        /// </summary>
        [JsonProperty("currency")]
        [STJS.JsonPropertyName("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// Maximum amount that can be charged per recurring interval.
        /// </summary>
        [JsonProperty("max_amount")]
        [JsonConverter(typeof(Int64StringConverter))]
        [STJS.JsonNumberHandling(STJS.JsonNumberHandling.AllowReadingFromString | STJS.JsonNumberHandling.WriteAsString)]
        [STJS.JsonPropertyName("max_amount")]
        public long? MaxAmount { get; set; }

        /// <summary>
        /// Interval over which <c>max_amount</c> applies.
        /// One of: <c>month</c>, <c>week</c>, or <c>year</c>.
        /// </summary>
        [JsonProperty("recurring_interval")]
        [STJS.JsonPropertyName("recurring_interval")]
        public string RecurringInterval { get; set; }
    }
}
