// File generated from our OpenAPI spec
namespace Stripe.ThreeDSecure
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AuthenticationCreateOptions : BaseOptions, IHasMetadata
    {
        private Dictionary<string, string> metadata;

        /// <summary>
        /// Contains additional details about the acquirer for this 3DS Authentication.
        ///
        /// Refer to the <a
        /// href="https://stripe.com/payments/3d-secure/standalone-3d-secure#pass-acquirer-details-and-directory-server">Pass
        /// acquirer details and directory server section of the standalone 3DS guide</a> for more
        /// information.
        /// </summary>
        [JsonProperty("acquirer_details")]
        [STJS.JsonPropertyName("acquirer_details")]
        public AuthenticationAcquirerDetailsOptions AcquirerDetails { get; set; }

        /// <summary>
        /// A non-negative integer representing the amount in the <a
        /// href="https://stripe.com/currencies#zero-decimal">smallest currency unit</a>. You can't
        /// include this parameter if <c>message_category</c> is <c>non_payment_authentication</c>.
        /// </summary>
        [JsonProperty("amount")]
        [STJS.JsonPropertyName("amount")]
        public long? Amount { get; set; }

        /// <summary>
        /// Contains additional details on the channel used for this 3DS Authentication.
        /// </summary>
        [JsonProperty("channel")]
        [STJS.JsonPropertyName("channel")]
        public AuthenticationChannelOptions Channel { get; set; }

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
        /// Contains additional details on your flow preference for this 3DS Authentication.
        ///
        /// Refer to the <a
        /// href="https://stripe.com/payments/3d-secure/standalone-3d-secure#specify-a-flow-preference">Specify
        /// a flow preference section of the standalone 3DS guide</a> for more information.
        /// </summary>
        [JsonProperty("flow_preference")]
        [STJS.JsonPropertyName("flow_preference")]
        public AuthenticationFlowPreferenceOptions FlowPreference { get; set; }

        /// <summary>
        /// Contains information about future usage of this 3DS Authentication.
        /// </summary>
        [JsonProperty("future_usage")]
        [STJS.JsonPropertyName("future_usage")]
        public AuthenticationFutureUsageOptions FutureUsage { get; set; }

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
        /// object in a structured format. Individual keys can be unset by posting an empty value to
        /// them. All keys can be unset by posting an empty value to <c>metadata</c>.
        /// </summary>
        [JsonProperty("metadata", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("metadata")]
        [STJS.JsonIgnore(Condition = STJS.JsonIgnoreCondition.WhenWritingNull)]
        public Dictionary<string, string> Metadata
        {
            get => this.metadata;
            set
            {
                this.metadata = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// ID of the payment method (a PaymentMethod object) to attach to this 3DS Authentication.
        /// </summary>
        [JsonProperty("payment_method")]
        [STJS.JsonPropertyName("payment_method")]
        public string PaymentMethod { get; set; }

        /// <summary>
        /// Hash used to generate the PaymentMethod to be used for this Authentication. This is
        /// mutually exclusive with the <c>payment_method</c> parameter.
        /// </summary>
        [JsonProperty("payment_method_data")]
        [STJS.JsonPropertyName("payment_method_data")]
        public AuthenticationPaymentMethodDataOptions PaymentMethodData { get; set; }

        /// <summary>
        /// The reason for invoking standalone 3DS. This is tailored specifically for cases when you
        /// want Stripe to help determine the standalone 3DS flow to fit your use case instead of
        /// needing to select a specific 3DS flow.
        ///
        /// This parameter is exclusive with <c>flow_preference</c>. You can either use
        /// <c>reason</c> for controlling 3DS according to your business requirements, or use
        /// <c>flow_preference</c> for having fine-grained control over your 3DS flow preference.
        /// One of: <c>cardholder_authentication</c>, <c>issuer_requested</c>,
        /// <c>liability_shift</c>, <c>processing_costs</c>, or <c>regulatory_compliance</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("reason")]
        [STJS.JsonPropertyName("reason")]
        public string Reason { get; set; }

        /// <summary>
        /// The shipping address requested by the cardholder. You should try to include as complete
        /// address information as possible.
        /// </summary>
        [JsonProperty("shipping_address")]
        [STJS.JsonPropertyName("shipping_address")]
        public AddressOptions ShippingAddress { get; set; }

        /// <summary>
        /// Set to <c>always</c> to skip the fingerprinting step and submit this Authentication
        /// immediately or <c>if_fingerprinting_not_supported</c> to submit this Authentication only
        /// if fingerprinting is not available. This parameter defaults to <c>never</c>.
        ///
        /// Refer to the <a
        /// href="https://stripe.com/payments/3d-secure/standalone-3d-secure#submit-at-creation">Submit
        /// at creation section of the standalone 3DS guide</a> for more information.
        /// One of: <c>always</c>, <c>if_fingerprinting_not_supported</c>, or <c>never</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("submit")]
        [STJS.JsonPropertyName("submit")]
        public string Submit { get; set; }
    }
}
