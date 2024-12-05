// File generated from our OpenAPI spec
namespace Stripe.Terminal
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class ReaderRefundPaymentOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// A positive integer in <strong>cents</strong> representing how much of this charge to
        /// refund.
        /// </summary>
        [JsonProperty("amount")]
        public long? Amount { get; set; }

        /// <summary>
        /// ID of the Charge to refund.
        /// </summary>
        [JsonProperty("charge")]
        public string Charge { get; set; }

        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format. Individual keys can be unset by posting an empty value to
        /// them. All keys can be unset by posting an empty value to <c>metadata</c>.
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// ID of the PaymentIntent to refund.
        /// </summary>
        [JsonProperty("payment_intent")]
        public string PaymentIntent { get; set; }

        /// <summary>
        /// Boolean indicating whether the application fee should be refunded when refunding this
        /// charge. If a full charge refund is given, the full application fee will be refunded.
        /// Otherwise, the application fee will be refunded in an amount proportional to the amount
        /// of the charge refunded. An application fee can be refunded only by the application that
        /// created the charge.
        /// </summary>
        [JsonProperty("refund_application_fee")]
        public bool? RefundApplicationFee { get; set; }

        /// <summary>
        /// Configuration overrides.
        /// </summary>
        [JsonProperty("refund_payment_config")]
        public ReaderRefundPaymentConfigOptions RefundPaymentConfig { get; set; }

        /// <summary>
        /// Boolean indicating whether the transfer should be reversed when refunding this charge.
        /// The transfer will be reversed proportionally to the amount being refunded (either the
        /// entire or partial amount). A transfer can be reversed only by the application that
        /// created the charge.
        /// </summary>
        [JsonProperty("reverse_transfer")]
        public bool? ReverseTransfer { get; set; }
    }
}
