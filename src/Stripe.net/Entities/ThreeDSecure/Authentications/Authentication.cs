// File generated from our OpenAPI spec
namespace Stripe.ThreeDSecure
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// The Standalone 3DS API allows you to run EMV 3D Secure (3DS) authentication using Stripe
    /// while authorizing the payment with any PSP.
    ///
    /// Related guide: <a
    /// href="https://stripe.com/payments/3d-secure/standalone-3d-secure">Standalone 3DS</a>.
    /// </summary>
    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class Authentication : StripeEntity<Authentication>, IHasId, IHasMetadata, IHasObject
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
        /// Contains additional details about the acquirer for a 3DS Authentication.
        /// </summary>
        [JsonProperty("acquirer_details")]
        [STJS.JsonPropertyName("acquirer_details")]
        public AuthenticationAcquirerDetails AcquirerDetails { get; set; }

        /// <summary>
        /// The amount for this 3DS Authentication.
        /// </summary>
        [JsonProperty("amount")]
        [STJS.JsonPropertyName("amount")]
        public long Amount { get; set; }

        /// <summary>
        /// The URL for presenting a challenge to your cardholder, present if status is
        /// requires_challenge.
        /// </summary>
        [JsonProperty("challenge_url")]
        [STJS.JsonPropertyName("challenge_url")]
        public string ChallengeUrl { get; set; }

        /// <summary>
        /// Contains details on the channel used (browser, 3RI) for a standalone 3DS Authentication.
        /// </summary>
        [JsonProperty("channel")]
        [STJS.JsonPropertyName("channel")]
        public AuthenticationChannel Channel { get; set; }

        /// <summary>
        /// Time at which the object was created. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("created")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Three-letter <a href="https://www.iso.org/iso-4217-currency-codes.html">ISO currency
        /// code</a>, in lowercase. Must be a <a href="https://stripe.com/docs/currencies">supported
        /// currency</a>.
        /// </summary>
        [JsonProperty("currency")]
        [STJS.JsonPropertyName("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// The 3DS directory server with which this 3DS Authentication was processed.
        /// One of: <c>american_express</c>, <c>cartes_bancaires</c>, <c>discover</c>,
        /// <c>mastercard</c>, or <c>visa</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("directory_server")]
        [STJS.JsonPropertyName("directory_server")]
        public string DirectoryServer { get; set; }

        /// <summary>
        /// The URL for performing issuer fingerprinting, present if fingerprinting is supported for
        /// the given payment method.
        /// </summary>
        [JsonProperty("fingerprinting_url")]
        [STJS.JsonPropertyName("fingerprinting_url")]
        public string FingerprintingUrl { get; set; }

        /// <summary>
        /// Contains details of the flow preference used for a standalone 3DS Authentication.
        /// </summary>
        [JsonProperty("flow_preference")]
        [STJS.JsonPropertyName("flow_preference")]
        public AuthenticationFlowPreference FlowPreference { get; set; }

        /// <summary>
        /// Contains information about the future authorisations related to this authentication.
        /// </summary>
        [JsonProperty("future_usage")]
        [STJS.JsonPropertyName("future_usage")]
        public AuthenticationFutureUsage FutureUsage { get; set; }

        /// <summary>
        /// If the object exists in live mode, the value is <c>true</c>. If the object exists in
        /// test mode, the value is <c>false</c>.
        /// </summary>
        [JsonProperty("livemode")]
        [STJS.JsonPropertyName("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// Indicates whether this 3DS Authentication is being performed for a payment or
        /// non-payment use case.
        /// One of: <c>non_payment_authentication</c>, or <c>payment_authentication</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("message_category")]
        [STJS.JsonPropertyName("message_category")]
        public string MessageCategory { get; set; }

        /// <summary>
        /// Set of <a href="https://docs.stripe.com/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format.
        /// </summary>
        [JsonProperty("metadata")]
        [STJS.JsonPropertyName("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// The outcome of this 3DS Authentication.
        /// One of: <c>abandoned</c>, <c>attempt_acknowledged</c>, <c>authenticated</c>,
        /// <c>canceled</c>, <c>denied</c>, <c>informational</c>, <c>internal_error</c>,
        /// <c>not_supported</c>, <c>not_triggered</c>, <c>processing_error</c>, or <c>rejected</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("outcome")]
        [STJS.JsonPropertyName("outcome")]
        public string Outcome { get; set; }

        /// <summary>
        /// Contains details on the result for a standalone 3DS Authentication.
        /// </summary>
        [JsonProperty("outcome_details")]
        [STJS.JsonPropertyName("outcome_details")]
        public AuthenticationOutcomeDetails OutcomeDetails { get; set; }

        #region Expandable PaymentMethod

        /// <summary>
        /// (ID of the PaymentMethod)
        /// ID of the payment method (a PaymentMethod object) to attach to this 3DS Authentication.
        /// </summary>
        [JsonIgnore]
        [STJS.JsonIgnore]
        public string PaymentMethodId
        {
            get => this.InternalPaymentMethod?.Id;
            set => this.InternalPaymentMethod = SetExpandableFieldId(value, this.InternalPaymentMethod);
        }

        /// <summary>
        /// (Expanded)
        /// ID of the payment method (a PaymentMethod object) to attach to this 3DS Authentication.
        ///
        /// For more information, see the <a href="https://stripe.com/docs/expand">expand documentation</a>.
        /// </summary>
        [JsonIgnore]
        [STJS.JsonIgnore]
        public PaymentMethod PaymentMethod
        {
            get => this.InternalPaymentMethod?.ExpandedObject;
            set => this.InternalPaymentMethod = SetExpandableFieldObject(value, this.InternalPaymentMethod);
        }

        [JsonProperty("payment_method")]
        [JsonConverter(typeof(ExpandableFieldConverter<PaymentMethod>))]
        [STJS.JsonPropertyName("payment_method")]
        [STJS.JsonConverter(typeof(STJExpandableFieldConverter<PaymentMethod>))]
        internal ExpandableField<PaymentMethod> InternalPaymentMethod { get; set; }
        #endregion

        /// <summary>
        /// The reason for invoking this 3DS Authentication.
        /// One of: <c>cardholder_authentication</c>, <c>issuer_requested</c>,
        /// <c>liability_shift</c>, <c>processing_costs</c>, or <c>regulatory_compliance</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("reason")]
        [STJS.JsonPropertyName("reason")]
        public string Reason { get; set; }

        /// <summary>
        /// Contains details about the shipping address for a 3DS Authentication.
        /// </summary>
        [JsonProperty("shipping_address")]
        [STJS.JsonPropertyName("shipping_address")]
        public AuthenticationShippingAddress ShippingAddress { get; set; }

        /// <summary>
        /// Status of this Authentication.
        /// One of: <c>canceled</c>, <c>error</c>, <c>failed</c>, <c>requires_challenge</c>,
        /// <c>requires_submission</c>, or <c>succeeded</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("status")]
        [STJS.JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
