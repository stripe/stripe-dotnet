// File generated from our OpenAPI spec
namespace Stripe.Terminal
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    /// <summary>
    /// Returns data collected by Terminal readers. This data is only stored for 24 hours.
    /// </summary>
    public class ReaderCollectedData : StripeEntity<ReaderCollectedData>, IHasId, IHasObject
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
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// The magstripe data collected by the reader.
        /// </summary>
        [JsonProperty("magstripe")]
        public ReaderCollectedDataMagstripe Magstripe { get; set; }

        /// <summary>
        /// The type of data collected by the reader.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
