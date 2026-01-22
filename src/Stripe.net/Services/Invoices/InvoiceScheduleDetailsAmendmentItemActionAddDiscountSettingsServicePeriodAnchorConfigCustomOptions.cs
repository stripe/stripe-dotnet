// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class InvoiceScheduleDetailsAmendmentItemActionAddDiscountSettingsServicePeriodAnchorConfigCustomOptions : INestedOptions
    {
        /// <summary>
        /// The day of the month the anchor should be. Ranges from 1 to 31.
        /// </summary>
        [JsonProperty("day_of_month")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("day_of_month")]
#endif
        public long? DayOfMonth { get; set; }

        /// <summary>
        /// The hour of the day the anchor should be. Ranges from 0 to 23.
        /// </summary>
        [JsonProperty("hour")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("hour")]
#endif
        public long? Hour { get; set; }

        /// <summary>
        /// The minute of the hour the anchor should be. Ranges from 0 to 59.
        /// </summary>
        [JsonProperty("minute")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("minute")]
#endif
        public long? Minute { get; set; }

        /// <summary>
        /// The month to start full cycle periods. Ranges from 1 to 12.
        /// </summary>
        [JsonProperty("month")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("month")]
#endif
        public long? Month { get; set; }

        /// <summary>
        /// The second of the minute the anchor should be. Ranges from 0 to 59.
        /// </summary>
        [JsonProperty("second")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("second")]
#endif
        public long? Second { get; set; }
    }
}
