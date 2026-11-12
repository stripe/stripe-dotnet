// File generated from our OpenAPI spec
namespace Stripe.Radar
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class PaymentEvaluationCreateOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// Details about the Client Device Metadata to associate with the payment evaluation.
        /// </summary>
        [JsonProperty("client_device_metadata_details")]
        [STJS.JsonPropertyName("client_device_metadata_details")]
        public PaymentEvaluationClientDeviceMetadataDetailsOptions ClientDeviceMetadataDetails { get; set; }

        /// <summary>
        /// Details about the customer associated with the payment evaluation.
        /// </summary>
        [JsonProperty("customer_details")]
        [STJS.JsonPropertyName("customer_details")]
        public PaymentEvaluationCustomerDetailsOptions CustomerDetails { get; set; }

        /// <summary>
        /// Set of <a href="https://docs.stripe.com/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format. Individual keys can be unset by posting an empty value to
        /// them. All keys can be unset by posting an empty value to <c>metadata</c>.
        /// </summary>
        [JsonProperty("metadata")]
        [STJS.JsonPropertyName("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Details about the payment.
        /// </summary>
        [JsonProperty("payment_details")]
        [STJS.JsonPropertyName("payment_details")]
        public PaymentEvaluationPaymentDetailsOptions PaymentDetails { get; set; }

        /// <summary>
        /// The signals to return in the Payment Evaluation response. Must include
        /// <c>fraudulent_payment</c>. If omitted, only <c>fraudulent_payment</c> is returned.
        /// One of: <c>bank_initiated_return</c>, <c>card_testing</c>, <c>early_fraud_warning</c>,
        /// <c>fraudulent_dispute</c>, or <c>fraudulent_payment</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("requested_signals")]
        [STJS.JsonPropertyName("requested_signals")]
        public List<string> RequestedSignals { get; set; }
    }
}
