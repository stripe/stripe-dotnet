// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class PaymentRecordReportPaymentAttemptOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// An arbitrary string attached to the object. Often useful for displaying to users.
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Information about the payment attempt failure.
        /// </summary>
        [JsonProperty("failed")]
        public PaymentRecordFailedOptions Failed { get; set; }

        /// <summary>
        /// Information about the payment attempt guarantee.
        /// </summary>
        [JsonProperty("guaranteed")]
        public PaymentRecordGuaranteedOptions Guaranteed { get; set; }

        /// <summary>
        /// When the reported payment was initiated. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("initiated_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? InitiatedAt { get; set; }

        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format. Individual keys can be unset by posting an empty value to
        /// them. All keys can be unset by posting an empty value to <c>metadata</c>.
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// The outcome of the reported payment.
        /// One of: <c>failed</c>, or <c>guaranteed</c>.
        /// </summary>
        [JsonProperty("outcome")]
        public string Outcome { get; set; }

        /// <summary>
        /// Information about the Payment Method debited for this payment.
        /// </summary>
        [JsonProperty("payment_method_details")]
        public PaymentRecordPaymentMethodDetailsOptions PaymentMethodDetails { get; set; }

        /// <summary>
        /// Shipping information for this payment.
        /// </summary>
        [JsonProperty("shipping_details")]
        public PaymentRecordShippingDetailsOptions ShippingDetails { get; set; }
    }
}
