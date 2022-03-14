// File generated from our OpenAPI spec
namespace Stripe.TestHelpers
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    /// <summary>
    /// A test clock enables deterministic control over objects in testmode. With a test clock,
    /// you can create objects at a frozen time in the past or future, and advance to a specific
    /// future time to observe webhooks and state changes. After the clock advances, you can
    /// either validate the current state of your scenario (and test your assumptions), change
    /// the current state of your scenario (and test more complex scenarios), or keep advancing
    /// forward in time.
    /// </summary>
    public class TestClock : StripeEntity<TestClock>, IHasId, IHasObject
    {
        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value.
        /// </summary>
        [JsonProperty("object")]
        public string Object { get; set; }

        /// <summary>
        /// Time at which the object was created. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Whether this object is deleted or not.
        /// </summary>
        [JsonProperty("deleted", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Deleted { get; set; }

        /// <summary>
        /// Time at which this clock is scheduled to auto delete.
        /// </summary>
        [JsonProperty("deletes_after")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime DeletesAfter { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Time at which all objects belonging to this clock are frozen.
        /// </summary>
        [JsonProperty("frozen_time")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime FrozenTime { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// The custom name supplied at creation.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// The status of the Test Clock.
        /// One of: <c>advancing</c>, <c>internal_failure</c>, or <c>ready</c>.
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }
    }
}
