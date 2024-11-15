// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class OutboundPaymentCreateOptions : BaseOptions, IHasMetadata
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
        /// ID of the customer to whom the OutboundPayment is sent. Must match the Customer attached
        /// to the <c>destination_payment_method</c> passed in.
        /// </summary>
        [JsonProperty("customer")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("customer")]
#endif

        public string Customer { get; set; }

        /// <summary>
        /// An arbitrary string attached to the object. Often useful for displaying to users.
        /// </summary>
        [JsonProperty("description")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("description")]
#endif

        public string Description { get; set; }

        /// <summary>
        /// The PaymentMethod to use as the payment instrument for the OutboundPayment. Exclusive
        /// with <c>destination_payment_method_data</c>.
        /// </summary>
        [JsonProperty("destination_payment_method")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("destination_payment_method")]
#endif

        public string DestinationPaymentMethod { get; set; }

        /// <summary>
        /// Hash used to generate the PaymentMethod to be used for this OutboundPayment. Exclusive
        /// with <c>destination_payment_method</c>.
        /// </summary>
        [JsonProperty("destination_payment_method_data")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("destination_payment_method_data")]
#endif

        public OutboundPaymentDestinationPaymentMethodDataOptions DestinationPaymentMethodData { get; set; }

        /// <summary>
        /// Payment method-specific configuration for this OutboundPayment.
        /// </summary>
        [JsonProperty("destination_payment_method_options")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("destination_payment_method_options")]
#endif

        public OutboundPaymentDestinationPaymentMethodOptionsOptions DestinationPaymentMethodOptions { get; set; }

        /// <summary>
        /// End user details.
        /// </summary>
        [JsonProperty("end_user_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("end_user_details")]
#endif

        public OutboundPaymentEndUserDetailsOptions EndUserDetails { get; set; }

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
        /// The description that appears on the receiving end for this OutboundPayment (for example,
        /// bank statement for external bank transfer). Maximum 10 characters for <c>ach</c>
        /// payments, 140 characters for <c>us_domestic_wire</c> payments, or 500 characters for
        /// <c>stripe</c> network transfers. The default value is "payment".
        /// </summary>
        [JsonProperty("statement_descriptor")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("statement_descriptor")]
#endif

        public string StatementDescriptor { get; set; }
    }
}
