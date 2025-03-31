// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class OutboundTransferCreateOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// Amount (in cents) to be transferred.
        /// </summary>
        [JsonProperty("amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount")]
#endif
        public long? Amount { get; set; }

        /// <summary>
        /// Three-letter <a href="https://www.iso.org/iso-4217-currency-codes.html">ISO currency
        /// code</a>, in lowercase. Must be a <a href="https://stripe.com/docs/currencies">supported
        /// currency</a>.
        /// </summary>
        [JsonProperty("currency")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("currency")]
#endif
        public string Currency { get; set; }

        /// <summary>
        /// An arbitrary string attached to the object. Often useful for displaying to users.
        /// </summary>
        [JsonProperty("description")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("description")]
#endif
        public string Description { get; set; }

        /// <summary>
        /// The PaymentMethod to use as the payment instrument for the OutboundTransfer.
        /// </summary>
        [JsonProperty("destination_payment_method")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("destination_payment_method")]
#endif
        public string DestinationPaymentMethod { get; set; }

        /// <summary>
        /// Hash used to generate the PaymentMethod to be used for this OutboundTransfer. Exclusive
        /// with <c>destination_payment_method</c>.
        /// </summary>
        [JsonProperty("destination_payment_method_data")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("destination_payment_method_data")]
#endif
        public OutboundTransferDestinationPaymentMethodDataOptions DestinationPaymentMethodData { get; set; }

        /// <summary>
        /// Hash describing payment method configuration details.
        /// </summary>
        [JsonProperty("destination_payment_method_options")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("destination_payment_method_options")]
#endif
        public OutboundTransferDestinationPaymentMethodOptionsOptions DestinationPaymentMethodOptions { get; set; }

        /// <summary>
        /// The FinancialAccount to pull funds from.
        /// </summary>
        [JsonProperty("financial_account")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("financial_account")]
#endif
        public string FinancialAccount { get; set; }

        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
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
        /// Statement descriptor to be shown on the receiving end of an OutboundTransfer. Maximum 10
        /// characters for <c>ach</c> transfers or 140 characters for <c>us_domestic_wire</c>
        /// transfers. The default value is "transfer".
        /// </summary>
        [JsonProperty("statement_descriptor")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("statement_descriptor")]
#endif
        public string StatementDescriptor { get; set; }
    }
}
