// File generated from our OpenAPI spec
namespace Stripe.Billing
{
    using Newtonsoft.Json;

    /// <summary>
    /// A billing meter event adjustment represents the status of a meter event adjustment.
    /// </summary>
    public class MeterEventAdjustment : StripeEntity<MeterEventAdjustment>, IHasObject
    {
        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value.
        /// </summary>
        [JsonProperty("object")]
        public string Object { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// The meter event adjustment's status.
        /// One of: <c>complete</c>, or <c>pending</c>.
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }
    }
}
