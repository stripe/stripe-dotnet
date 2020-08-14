namespace Stripe
{
    using Newtonsoft.Json;

    public class SubscriptionScheduleReleaseOptions : BaseOptions
    {
        /// <summary>
        /// Keep any cancellation on the subscription that the schedule has set.
        /// </summary>
        [JsonProperty("preserve_cancel_date")]
        public bool? PreserveCancelDate { get; set; }
    }
}
