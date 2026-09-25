// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class SubscriptionSchedulePauseScheduleResumeStatus : StripeEntity<SubscriptionSchedulePauseScheduleResumeStatus>
    {
        [JsonProperty("error")]
        [STJS.JsonPropertyName("error")]
        public SubscriptionSchedulePauseScheduleResumeStatusError Error { get; set; }

        /// <summary>
        /// The lifecycle state of the resume operation.
        /// One of: <c>error</c>, <c>pending</c>, <c>requires_action</c>, <c>scheduled</c>, or
        /// <c>succeeded</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
