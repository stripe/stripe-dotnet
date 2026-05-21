// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// A Payment Location Capability represents a capability for a Stripe account at a Payment
    /// Location.
    /// </summary>
    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PaymentLocationCapability : StripeEntity<PaymentLocationCapability>, IHasObject, IHasId
    {
        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value.
        /// </summary>
        [JsonProperty("object")]
        [STJS.JsonPropertyName("object")]
        public string Object { get; set; }

        /// <summary>
        /// The account for which the capability enables functionality.
        /// </summary>
        [JsonProperty("account")]
        [STJS.JsonPropertyName("account")]
        public string Account { get; set; }

        /// <summary>
        /// The identifier for the capability.
        /// </summary>
        [JsonProperty("capability")]
        [STJS.JsonPropertyName("capability")]
        public string Capability { get; set; }

        /// <summary>
        /// If the object exists in live mode, the value is <c>true</c>. If the object exists in
        /// test mode, the value is <c>false</c>.
        /// </summary>
        [JsonProperty("livemode")]
        [STJS.JsonPropertyName("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// The payment location for which the capability enables functionality.
        /// </summary>
        [JsonProperty("location")]
        [STJS.JsonPropertyName("location")]
        public string Location { get; set; }

        /// <summary>
        /// Whether the capability has been requested.
        /// </summary>
        [JsonProperty("requested")]
        [STJS.JsonPropertyName("requested")]
        public bool Requested { get; set; }

        /// <summary>
        /// Time at which the capability was requested. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("requested_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("requested_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime? RequestedAt { get; set; }

        [JsonProperty("requirements")]
        [STJS.JsonPropertyName("requirements")]
        public PaymentLocationCapabilityRequirements Requirements { get; set; }

        /// <summary>
        /// The status of the capability.
        /// One of: <c>active</c>, <c>inactive</c>, <c>pending</c>, or <c>unrequested</c>.
        /// </summary>
        [JsonProperty("status")]
        [STJS.JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonIgnore]
        [STJS.JsonIgnore]
        public string Id { get => this.Capability; set => this.Capability = value; }
    }
}
