// File generated from our OpenAPI spec
namespace Stripe.Radar
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    /// <summary>
    /// Payment Evaluations represent the risk lifecycle of an externally processed payment. It
    /// includes the Radar risk score from Stripe, payment outcome taken by the merchant or
    /// processor, and any post transaction events, such as refunds or disputes. See the <a
    /// href="https://stripe.com/radar/multiprocessor">Radar API guide</a> for integration
    /// steps.
    /// </summary>
    public class PaymentEvaluation : StripeEntity<PaymentEvaluation>, IHasId, IHasMetadata, IHasObject
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
        /// Client device metadata attached to this payment evaluation.
        /// </summary>
        [JsonProperty("client_device_metadata_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("client_device_metadata_details")]
#endif
        public PaymentEvaluationClientDeviceMetadataDetails ClientDeviceMetadataDetails { get; set; }

        /// <summary>
        /// Time at which the object was created. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("created_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("created_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif
        public DateTime CreatedAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Customer details attached to this payment evaluation.
        /// </summary>
        [JsonProperty("customer_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("customer_details")]
#endif
        public PaymentEvaluationCustomerDetails CustomerDetails { get; set; }

        /// <summary>
        /// Event information associated with the payment evaluation, such as refunds, dispute,
        /// early fraud warnings, or user interventions.
        /// </summary>
        [JsonProperty("events")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("events")]
#endif
        public List<PaymentEvaluationEvent> Events { get; set; }

        /// <summary>
        /// Collection of scores and insights for this payment evaluation.
        /// </summary>
        [JsonProperty("insights")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("insights")]
#endif
        public PaymentEvaluationInsights Insights { get; set; }

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
        /// Set of <a href="https://docs.stripe.com/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format.
        /// </summary>
        [JsonProperty("metadata")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("metadata")]
#endif
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Indicates the final outcome for the payment evaluation.
        /// </summary>
        [JsonProperty("outcome")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("outcome")]
#endif
        public PaymentEvaluationOutcome Outcome { get; set; }

        /// <summary>
        /// Payment details attached to this payment evaluation.
        /// </summary>
        [JsonProperty("payment_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payment_details")]
#endif
        public PaymentEvaluationPaymentDetails PaymentDetails { get; set; }
    }
}
