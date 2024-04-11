// File generated from our OpenAPI spec
namespace Stripe.Billing
{
    using Newtonsoft.Json;

    /// <summary>
    /// A billing meter event adjustment is a resource that allows you to cancel a meter event.
    /// For example, you might create a billing meter event adjustment to cancel a meter event
    /// that was created in error or attached to the wrong customer.
    /// </summary>
    public class MeterEventAdjustment : StripeEntity<MeterEventAdjustment>, IHasObject
    {
        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value.
        /// </summary>
        [JsonProperty("object")]
        public string Object { get; set; }

        /// <summary>
        /// Specifies which event to cancel.
        /// </summary>
        [JsonProperty("cancel")]
        public MeterEventAdjustmentCancel Cancel { get; set; }

        /// <summary>
        /// The name of the meter event. Corresponds with the <c>event_name</c> field on a meter.
        /// </summary>
        [JsonProperty("event_name")]
        public string EventName { get; set; }

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

        /// <summary>
        /// Specifies whether to cancel a single event or a range of events for a time period. Time
        /// period cancellation is not supported yet.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
