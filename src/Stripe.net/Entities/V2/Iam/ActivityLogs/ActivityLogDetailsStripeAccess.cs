// File generated from our OpenAPI spec
namespace Stripe.V2.Iam
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ActivityLogDetailsStripeAccess : StripeEntity<ActivityLogDetailsStripeAccess>
    {
        /// <summary>
        /// The level of Dashboard access granted.
        /// One of: <c>dashboard_read_only</c>, or <c>dashboard_read_write</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("access_type")]
        [STJS.JsonPropertyName("access_type")]
        public string AccessType { get; set; }

        /// <summary>
        /// The reason for granting Stripe access.
        /// </summary>
        [JsonProperty("reason")]
        [STJS.JsonPropertyName("reason")]
        public ActivityLogDetailsStripeAccessReason Reason { get; set; }
    }
}
