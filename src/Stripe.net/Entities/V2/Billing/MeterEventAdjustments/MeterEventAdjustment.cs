// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// A Meter Event Adjustment is used to cancel or modify previously recorded meter events.
    /// Meter Event Adjustments allow you to correct billing data by canceling individual events
    /// or event ranges, with tracking of adjustment status and creation time.
    /// </summary>
    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class MeterEventAdjustment : StripeEntity<MeterEventAdjustment>, IHasId, IHasObject
    {
        /// <summary>
        /// The unique ID of this meter event adjustment.
        /// </summary>
        [JsonProperty("id")]
        [STJS.JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value of
        /// the object field.
        /// </summary>
        [JsonProperty("object")]
        [STJS.JsonPropertyName("object")]
        public string Object { get; set; }

        /// <summary>
        /// Specifies which event to cancel.
        /// </summary>
        [JsonProperty("cancel")]
        [STJS.JsonPropertyName("cancel")]
        public MeterEventAdjustmentCancel Cancel { get; set; }

        /// <summary>
        /// The time the adjustment was created.
        /// </summary>
        [JsonProperty("created")]
        [STJS.JsonPropertyName("created")]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// The name of the meter event. Corresponds with the <c>event_name</c> field on a meter.
        /// </summary>
        [JsonProperty("event_name")]
        [STJS.JsonPropertyName("event_name")]
        public string EventName { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
        [STJS.JsonPropertyName("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// Open Enum. The meter event adjustment’s status.
        /// One of: <c>complete</c>, or <c>pending</c>.
        /// </summary>
        [JsonProperty("status")]
        [STJS.JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// Open Enum. Specifies the type of cancellation. Currently supports canceling a single
        /// event.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
