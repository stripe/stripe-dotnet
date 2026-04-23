// File generated from our OpenAPI spec
namespace Stripe.SharedPayment
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// A SharedPaymentIssuedToken is a limited-use reference to a PaymentMethod that can be
    /// created with a secret key. When shared with another Stripe account (Seller), it enables
    /// that account to either process a payment on Stripe against a PaymentMethod that your
    /// Stripe account owns, or to forward a usable credential created against the
    /// originalPaymentMethod to then process the payment off-Stripe.
    /// </summary>
    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class IssuedToken : StripeEntity<IssuedToken>, IHasId, IHasObject
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
        /// Time at which this SharedPaymentIssuedToken was deactivated.
        /// </summary>
        [JsonProperty("deactivated_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("deactivated_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime? DeactivatedAt { get; set; }

        /// <summary>
        /// The reason why the SharedPaymentIssuedToken has been deactivated.
        /// One of: <c>consumed</c>, <c>expired</c>, <c>resolved</c>, or <c>revoked</c>.
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
        /// If present, describes the action required to make this <c>SharedPaymentIssuedToken</c>
        /// usable for payments. Present when the token is in <c>requires_action</c> state.
        /// </summary>
        [JsonProperty("next_action")]
        [STJS.JsonPropertyName("next_action")]
        public IssuedTokenNextAction NextAction { get; set; }

        /// <summary>
        /// ID of an existing PaymentMethod.
        /// </summary>
        [JsonProperty("payment_method")]
        [STJS.JsonPropertyName("payment_method")]
        public string PaymentMethod { get; set; }

        /// <summary>
        /// If the customer does not exit their browser while authenticating, they will be
        /// redirected to this specified URL after completion.
        /// </summary>
        [JsonProperty("return_url")]
        [STJS.JsonPropertyName("return_url")]
        public string ReturnUrl { get; set; }

        /// <summary>
        /// Risk details of the SharedPaymentIssuedToken.
        /// </summary>
        [JsonProperty("risk_details")]
        [STJS.JsonPropertyName("risk_details")]
        public IssuedTokenRiskDetails RiskDetails { get; set; }

        /// <summary>
        /// Seller details of the SharedPaymentIssuedToken, including network_id and external_id.
        /// </summary>
        [JsonProperty("seller_details")]
        [STJS.JsonPropertyName("seller_details")]
        public IssuedTokenSellerDetails SellerDetails { get; set; }

        /// <summary>
        /// Indicates that you intend to save the PaymentMethod of this SharedPaymentToken to a
        /// customer later.
        /// </summary>
        [JsonProperty("setup_future_usage")]
        [STJS.JsonPropertyName("setup_future_usage")]
        public string SetupFutureUsage { get; set; }

        /// <summary>
        /// Metadata about the SharedPaymentIssuedToken.
        /// </summary>
        [JsonProperty("shared_metadata")]
        [STJS.JsonPropertyName("shared_metadata")]
        public Dictionary<string, string> SharedMetadata { get; set; }

        /// <summary>
        /// Status of this SharedPaymentIssuedToken, one of <c>active</c>, <c>requires_action</c>,
        /// or <c>deactivated</c>.
        /// One of: <c>active</c>, <c>deactivated</c>, or <c>requires_action</c>.
        /// </summary>
        [JsonProperty("status")]
        [STJS.JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// Usage details of the SharedPaymentIssuedToken.
        /// </summary>
        [JsonProperty("usage_details")]
        [STJS.JsonPropertyName("usage_details")]
        public IssuedTokenUsageDetails UsageDetails { get; set; }

        /// <summary>
        /// Usage limits of the SharedPaymentIssuedToken.
        /// </summary>
        [JsonProperty("usage_limits")]
        [STJS.JsonPropertyName("usage_limits")]
        public IssuedTokenUsageLimits UsageLimits { get; set; }
    }
}
