// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class ChargeCaptureOptions : BaseOptions
    {
        /// <summary>
        /// The amount to capture, which must be less than or equal to the original amount.
        /// </summary>
        [JsonProperty("amount")]
        [STJS.JsonPropertyName("amount")]
        public long? Amount { get; set; }

        /// <summary>
        /// An application fee to add on to this charge.
        /// </summary>
        [JsonProperty("application_fee")]
        [STJS.JsonPropertyName("application_fee")]
        public long? ApplicationFee { get; set; }

        /// <summary>
        /// An application fee amount to add on to this charge, which must be less than or equal to
        /// the original amount.
        /// </summary>
        [JsonProperty("application_fee_amount")]
        [STJS.JsonPropertyName("application_fee_amount")]
        public long? ApplicationFeeAmount { get; set; }

        [JsonProperty("exchange_rate")]
        [JsonConverter(typeof(DecimalStringConverter))]
        [STJS.JsonNumberHandling(STJS.JsonNumberHandling.AllowReadingFromString | STJS.JsonNumberHandling.WriteAsString)]
        [STJS.JsonPropertyName("exchange_rate")]
        public decimal? ExchangeRate { get; set; }

        /// <summary>
        /// Provides industry-specific information about the charge.
        /// </summary>
        [JsonProperty("payment_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payment_details")]
#endif
        public ChargePaymentDetailsOptions PaymentDetails { get; set; }

        /// <summary>
        /// The email address to send this charge's receipt to. This will override the
        /// previously-specified email address for this charge, if one was set. Receipts will not be
        /// sent in test mode.
        /// </summary>
        [JsonProperty("receipt_email")]
        [STJS.JsonPropertyName("receipt_email")]
        public string ReceiptEmail { get; set; }

        /// <summary>
        /// For a non-card charge, text that appears on the customer's statement as the statement
        /// descriptor. This value overrides the account's default statement descriptor. For
        /// information about requirements, including the 22-character limit, see <a
        /// href="https://docs.stripe.com/get-started/account/statement-descriptors">the Statement
        /// Descriptor docs</a>.
        ///
        /// For a card charge, this value is ignored unless you don't specify a
        /// <c>statement_descriptor_suffix</c>, in which case this value is used as the suffix.
        /// </summary>
        [JsonProperty("statement_descriptor")]
        [STJS.JsonPropertyName("statement_descriptor")]
        public string StatementDescriptor { get; set; }

        /// <summary>
        /// Provides information about a card charge. Concatenated to the account's <a
        /// href="https://docs.stripe.com/get-started/account/statement-descriptors#static">statement
        /// descriptor prefix</a> to form the complete statement descriptor that appears on the
        /// customer's statement. If the account has no prefix value, the suffix is concatenated to
        /// the account's statement descriptor.
        /// </summary>
        [JsonProperty("statement_descriptor_suffix")]
        [STJS.JsonPropertyName("statement_descriptor_suffix")]
        public string StatementDescriptorSuffix { get; set; }

        /// <summary>
        /// An optional dictionary including the account to automatically transfer to as part of a
        /// destination charge. <a href="https://docs.stripe.com/connect/destination-charges">See
        /// the Connect documentation</a> for details.
        /// </summary>
        [JsonProperty("transfer_data")]
        [STJS.JsonPropertyName("transfer_data")]
        public ChargeTransferDataOptions TransferData { get; set; }

        /// <summary>
        /// A string that identifies this transaction as part of a group. <c>transfer_group</c> may
        /// only be provided if it has not been set. See the <a
        /// href="https://docs.stripe.com/connect/separate-charges-and-transfers#transfer-options">Connect
        /// documentation</a> for details.
        /// </summary>
        [JsonProperty("transfer_group")]
        [STJS.JsonPropertyName("transfer_group")]
        public string TransferGroup { get; set; }
    }
}
