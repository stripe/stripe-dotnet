// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class ContractCreateBillingCycleAnchorConfigOptions : INestedOptions
    {
        /// <summary>
        /// Day of month (1-31).
        /// </summary>
        [JsonProperty("day_of_month")]
        [STJS.JsonPropertyName("day_of_month")]
        public long? DayOfMonth { get; set; }

        /// <summary>
        /// Hour of day in UTC (0-23).
        /// </summary>
        [JsonProperty("hour")]
        [STJS.JsonPropertyName("hour")]
        public long? Hour { get; set; }

        /// <summary>
        /// Minute of hour (0-59).
        /// </summary>
        [JsonProperty("minute")]
        [STJS.JsonPropertyName("minute")]
        public long? Minute { get; set; }

        /// <summary>
        /// Month of year (1-12).
        /// </summary>
        [JsonProperty("month_of_year")]
        [STJS.JsonPropertyName("month_of_year")]
        public long? MonthOfYear { get; set; }

        /// <summary>
        /// Second of minute (0-59).
        /// </summary>
        [JsonProperty("second")]
        [STJS.JsonPropertyName("second")]
        public long? Second { get; set; }
    }
}
