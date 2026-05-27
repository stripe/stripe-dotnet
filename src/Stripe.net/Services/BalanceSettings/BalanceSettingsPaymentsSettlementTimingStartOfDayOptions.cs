// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class BalanceSettingsPaymentsSettlementTimingStartOfDayOptions : INestedOptions
    {
        /// <summary>
        /// Hour at which the customized start of day begins according to the given timezone. Must
        /// be a <a
        /// href="https://stripe.com/connect/customized-start-of-day#available-timezones-and-cutoffs">supported
        /// customized start of day hour</a>.
        /// </summary>
        [JsonProperty("hour")]
        [STJS.JsonPropertyName("hour")]
        public long? Hour { get; set; }

        /// <summary>
        /// Minutes at which the customized start of day begins according to the given timezone.
        /// Must be either 0 or 30.
        /// </summary>
        [JsonProperty("minutes")]
        [STJS.JsonPropertyName("minutes")]
        public long? Minutes { get; set; }

        /// <summary>
        /// Timezone for the customized start of day. Must be a <a
        /// href="https://stripe.com/connect/customized-start-of-day#available-timezones-and-cutoffs">supported
        /// customized start of day timezone</a>.
        /// </summary>
        [JsonProperty("timezone")]
        [STJS.JsonPropertyName("timezone")]
        public string Timezone { get; set; }
    }
}
