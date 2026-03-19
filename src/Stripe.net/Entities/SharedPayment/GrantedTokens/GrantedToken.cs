// File generated from our OpenAPI spec
namespace Stripe.SharedPayment
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// SharedPaymentGrantedToken is the view-only resource of a SharedPaymentIssuedToken, which
    /// is a limited-use reference to a PaymentMethod. When another Stripe merchant shares a
    /// SharedPaymentIssuedToken with you, you can view attributes of the shared token using the
    /// SharedPaymentGrantedToken API, and use it with a PaymentIntent.
    /// </summary>
    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class GrantedToken : StripeEntity<GrantedToken>, IHasId, IHasObject
    {
        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        [JsonProperty("id")]
        [STJS.JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value.
        /// </summary>
        [JsonProperty("object")]
        [STJS.JsonPropertyName("object")]
        public string Object { get; set; }

        /// <summary>
        /// Time at which the object was created. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("created")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Time at which this SharedPaymentGrantedToken expires and can no longer be used to
        /// confirm a PaymentIntent.
        /// </summary>
        [JsonProperty("deactivated_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("deactivated_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime? DeactivatedAt { get; set; }

        /// <summary>
        /// The reason why the SharedPaymentGrantedToken has been deactivated.
        /// One of: <c>consumed</c>, <c>expired</c>, or <c>revoked</c>.
        /// </summary>
        [JsonProperty("deactivated_reason")]
        [STJS.JsonPropertyName("deactivated_reason")]
        public string DeactivatedReason { get; set; }

        /// <summary>
        /// If the object exists in live mode, the value is <c>true</c>. If the object exists in
        /// test mode, the value is <c>false</c>.
        /// </summary>
        [JsonProperty("livemode")]
        [STJS.JsonPropertyName("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// Metadata about the SharedPaymentGrantedToken.
        /// </summary>
        [JsonProperty("shared_metadata")]
        [STJS.JsonPropertyName("shared_metadata")]
        public Dictionary<string, string> SharedMetadata { get; set; }

        /// <summary>
        /// Some details about how the SharedPaymentGrantedToken has been used already.
        /// </summary>
        [JsonProperty("usage_details")]
        [STJS.JsonPropertyName("usage_details")]
        public GrantedTokenUsageDetails UsageDetails { get; set; }

        /// <summary>
        /// Limits on how this SharedPaymentGrantedToken can be used.
        /// </summary>
        [JsonProperty("usage_limits")]
        [STJS.JsonPropertyName("usage_limits")]
        public GrantedTokenUsageLimits UsageLimits { get; set; }
    }
}
