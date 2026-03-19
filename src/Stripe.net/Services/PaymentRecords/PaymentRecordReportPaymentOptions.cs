// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class PaymentRecordReportPaymentOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// The amount you initially requested for this payment.
        /// </summary>
        [JsonProperty("amount_requested")]
        [STJS.JsonPropertyName("amount_requested")]
        public PaymentRecordAmountRequestedOptions AmountRequested { get; set; }

        /// <summary>
        /// Customer information for this payment.
        /// </summary>
        [JsonProperty("customer_details")]
        [STJS.JsonPropertyName("customer_details")]
        public PaymentRecordCustomerDetailsOptions CustomerDetails { get; set; }

        /// <summary>
        /// Indicates whether the customer was present in your checkout flow during this payment.
        /// One of: <c>off_session</c>, or <c>on_session</c>.
        /// </summary>
        [JsonProperty("customer_presence")]
        [STJS.JsonPropertyName("customer_presence")]
        public string CustomerPresence { get; set; }

        /// <summary>
        /// An arbitrary string attached to the object. Often useful for displaying to users.
        /// </summary>
        [JsonProperty("description")]
        [STJS.JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// Information about the payment attempt failure.
        /// </summary>
        [JsonProperty("failed")]
        [STJS.JsonPropertyName("failed")]
        public PaymentRecordFailedOptions Failed { get; set; }

        /// <summary>
        /// Information about the payment attempt guarantee.
        /// </summary>
        [JsonProperty("guaranteed")]
        [STJS.JsonPropertyName("guaranteed")]
        public PaymentRecordGuaranteedOptions Guaranteed { get; set; }

        /// <summary>
        /// When the reported payment was initiated. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("initiated_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("initiated_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime? InitiatedAt { get; set; }

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
        /// The outcome of the reported payment.
        /// One of: <c>failed</c>, or <c>guaranteed</c>.
        /// </summary>
        [JsonProperty("outcome")]
        [STJS.JsonPropertyName("outcome")]
        public string Outcome { get; set; }

        /// <summary>
        /// Information about the Payment Method debited for this payment.
        /// </summary>
        [JsonProperty("payment_method_details")]
        [STJS.JsonPropertyName("payment_method_details")]
        public PaymentRecordPaymentMethodDetailsOptions PaymentMethodDetails { get; set; }

        /// <summary>
        /// Processor information for this payment.
        /// </summary>
        [JsonProperty("processor_details")]
        [STJS.JsonPropertyName("processor_details")]
        public PaymentRecordProcessorDetailsOptions ProcessorDetails { get; set; }

        /// <summary>
        /// Shipping information for this payment.
        /// </summary>
        [JsonProperty("shipping_details")]
        [STJS.JsonPropertyName("shipping_details")]
        public PaymentRecordShippingDetailsOptions ShippingDetails { get; set; }
    }
}
