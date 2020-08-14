namespace Stripe
{
    using Newtonsoft.Json;

    public class SubscriptionScheduleReleaseOptions : BaseOptions
    {
        [JsonProperty("preserve_cancel_date")]
        public bool? PreserveCancelDate { get; set; }
    }
}
