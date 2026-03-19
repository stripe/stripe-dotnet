// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class SubscriptionScheduleReleaseOptions : BaseOptions
    {
        /// <summary>
        /// Keep any cancellation on the subscription that the schedule has set.
        /// </summary>
        [JsonProperty("preserve_cancel_date")]
        [STJS.JsonPropertyName("preserve_cancel_date")]
        public bool? PreserveCancelDate { get; set; }
    }
}
