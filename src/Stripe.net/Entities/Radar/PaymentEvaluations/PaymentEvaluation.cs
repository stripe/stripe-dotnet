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
        /// If the object exists in live mode, the value is <c>true</c>. If the object exists in
        /// test mode, the value is <c>false</c>.
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

        /// <summary>
        /// Recommended action based on the score of the fraudulent_payment signal. Possible values
        /// are <c>block</c> and <c>continue</c>.
        /// One of: <c>block</c>, or <c>continue</c>.
        /// </summary>
        [JsonProperty("recommended_action")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("recommended_action")]
#endif
        public string RecommendedAction { get; set; }

        /// <summary>
        /// Collection of signals for this payment evaluation.
        /// </summary>
        [JsonProperty("signals")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("signals")]
#endif
        public PaymentEvaluationSignals Signals { get; set; }
    }
}
