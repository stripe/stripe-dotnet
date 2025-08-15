// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class CadenceCreateBillingCycleDayTimeOptions : INestedOptions
    {
        /// <summary>
        /// The hour at which the billing cycle ends. This must be an integer between 0 and 23,
        /// inclusive. 0 represents midnight, and 23 represents 11 PM.
        /// </summary>
        [JsonProperty("hour")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("hour")]
#endif
        public long? Hour { get; set; }

        /// <summary>
        /// The minute at which the billing cycle ends. Must be an integer between 0 and 59,
        /// inclusive. Will default to the minute the cadence was created in UTC timezone.
        /// </summary>
        [JsonProperty("minute")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("minute")]
#endif
        public long? Minute { get; set; }
    }
}
