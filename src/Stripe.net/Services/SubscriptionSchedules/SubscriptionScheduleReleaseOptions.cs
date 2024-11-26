// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class SubscriptionScheduleReleaseOptions : BaseOptions
    {
        /// <summary>
        /// Keep any cancellation on the subscription that the schedule has set.
        /// </summary>
        [JsonProperty("preserve_cancel_date")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("preserve_cancel_date")]
#endif
        public bool? PreserveCancelDate { get; set; }
    }
}
