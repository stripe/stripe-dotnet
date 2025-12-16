// File generated from our OpenAPI spec
namespace Stripe.Terminal
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ReaderRefundPaymentOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// A positive integer in <strong>cents</strong> representing how much of this charge to
        /// refund.
        /// </summary>
        [JsonProperty("amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount")]
#endif
        public long? Amount { get; set; }

        /// <summary>
        /// ID of the Charge to refund.
        /// </summary>
        [JsonProperty("charge")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("charge")]
#endif
        public string Charge { get; set; }

        /// <summary>
        /// Set of <a href="https://docs.stripe.com/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format. Individual keys can be unset by posting an empty value to
        /// them. All keys can be unset by posting an empty value to <c>metadata</c>.
        /// </summary>
        [JsonProperty("metadata")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("metadata")]
#endif
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// ID of the PaymentIntent to refund.
        /// </summary>
        [JsonProperty("payment_intent")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payment_intent")]
#endif
        public string PaymentIntent { get; set; }

        /// <summary>
        /// Boolean indicating whether the application fee should be refunded when refunding this
        /// charge. If a full charge refund is given, the full application fee will be refunded.
        /// Otherwise, the application fee will be refunded in an amount proportional to the amount
        /// of the charge refunded. An application fee can be refunded only by the application that
        /// created the charge.
        /// </summary>
        [JsonProperty("refund_application_fee")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("refund_application_fee")]
#endif
        public bool? RefundApplicationFee { get; set; }

        /// <summary>
        /// Configuration overrides for this refund, such as customer cancellation settings.
        /// </summary>
        [JsonProperty("refund_payment_config")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("refund_payment_config")]
#endif
        public ReaderRefundPaymentConfigOptions RefundPaymentConfig { get; set; }

        /// <summary>
        /// Boolean indicating whether the transfer should be reversed when refunding this charge.
        /// The transfer will be reversed proportionally to the amount being refunded (either the
        /// entire or partial amount). A transfer can be reversed only by the application that
        /// created the charge.
        /// </summary>
        [JsonProperty("reverse_transfer")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("reverse_transfer")]
#endif
        public bool? ReverseTransfer { get; set; }
    }
}
