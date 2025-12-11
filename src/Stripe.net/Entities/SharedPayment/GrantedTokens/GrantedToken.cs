// File generated from our OpenAPI spec
namespace Stripe.SharedPayment
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    /// <summary>
    /// SharedPaymentGrantedToken is the view-only resource of a SharedPaymentIssuedToken, which
    /// is a limited-use reference to a PaymentMethod. When another Stripe merchant shares a
    /// SharedPaymentIssuedToken with you, you can view attributes of the shared token using the
    /// SharedPaymentGrantedToken API, and use it with a PaymentIntent.
    /// </summary>
    public class GrantedToken : StripeEntity<GrantedToken>, IHasId, IHasObject
    {
        /// <summary>
        /// Unique identifier for the object.
        /// </summary>
        [JsonProperty("id")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("id")]
#endif
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value.
        /// </summary>
        [JsonProperty("object")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("object")]
#endif
        public string Object { get; set; }

        /// <summary>
        /// Time at which the object was created. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("created")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Time at which this SharedPaymentGrantedToken expires and can no longer be used to
        /// confirm a PaymentIntent.
        /// </summary>
        [JsonProperty("deactivated_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("deactivated_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif
        public DateTime? DeactivatedAt { get; set; }

        /// <summary>
        /// The reason why the SharedPaymentGrantedToken has been deactivated.
        /// One of: <c>consumed</c>, <c>expired</c>, or <c>revoked</c>.
        /// </summary>
        [JsonProperty("deactivated_reason")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("deactivated_reason")]
#endif
        public string DeactivatedReason { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("livemode")]
#endif
        public bool Livemode { get; set; }

        /// <summary>
        /// Metadata about the SharedPaymentGrantedToken.
        /// </summary>
        [JsonProperty("shared_metadata")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("shared_metadata")]
#endif
        public Dictionary<string, string> SharedMetadata { get; set; }

        /// <summary>
        /// Some details about how the SharedPaymentGrantedToken has been used already.
        /// </summary>
        [JsonProperty("usage_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("usage_details")]
#endif
        public GrantedTokenUsageDetails UsageDetails { get; set; }

        /// <summary>
        /// Limits on how this SharedPaymentGrantedToken can be used.
        /// </summary>
        [JsonProperty("usage_limits")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("usage_limits")]
#endif
        public GrantedTokenUsageLimits UsageLimits { get; set; }
    }
}
