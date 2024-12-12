// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ConfirmationTokenPaymentMethodPreviewCardGeneratedFromPaymentMethodDetailsCardPresentReceipt : StripeEntity<ConfirmationTokenPaymentMethodPreviewCardGeneratedFromPaymentMethodDetailsCardPresentReceipt>
    {
        /// <summary>
        /// The type of account being debited or credited.
        /// One of: <c>checking</c>, <c>credit</c>, <c>prepaid</c>, or <c>unknown</c>.
        /// </summary>
        [JsonProperty("account_type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("account_type")]
#endif
        public string AccountType { get; set; }

        /// <summary>
        /// EMV tag 9F26, cryptogram generated by the integrated circuit chip.
        /// </summary>
        [JsonProperty("application_cryptogram")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("application_cryptogram")]
#endif
        public string ApplicationCryptogram { get; set; }

        /// <summary>
        /// Mnenomic of the Application Identifier.
        /// </summary>
        [JsonProperty("application_preferred_name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("application_preferred_name")]
#endif
        public string ApplicationPreferredName { get; set; }

        /// <summary>
        /// Identifier for this transaction.
        /// </summary>
        [JsonProperty("authorization_code")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("authorization_code")]
#endif
        public string AuthorizationCode { get; set; }

        /// <summary>
        /// EMV tag 8A. A code returned by the card issuer.
        /// </summary>
        [JsonProperty("authorization_response_code")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("authorization_response_code")]
#endif
        public string AuthorizationResponseCode { get; set; }

        /// <summary>
        /// Describes the method used by the cardholder to verify ownership of the card. One of the
        /// following: <c>approval</c>, <c>failure</c>, <c>none</c>, <c>offline_pin</c>,
        /// <c>offline_pin_and_signature</c>, <c>online_pin</c>, or <c>signature</c>.
        /// </summary>
        [JsonProperty("cardholder_verification_method")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("cardholder_verification_method")]
#endif
        public string CardholderVerificationMethod { get; set; }

        /// <summary>
        /// EMV tag 84. Similar to the application identifier stored on the integrated circuit chip.
        /// </summary>
        [JsonProperty("dedicated_file_name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("dedicated_file_name")]
#endif
        public string DedicatedFileName { get; set; }

        /// <summary>
        /// The outcome of a series of EMV functions performed by the card reader.
        /// </summary>
        [JsonProperty("terminal_verification_results")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("terminal_verification_results")]
#endif
        public string TerminalVerificationResults { get; set; }

        /// <summary>
        /// An indication of various EMV functions performed during the transaction.
        /// </summary>
        [JsonProperty("transaction_status_information")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("transaction_status_information")]
#endif
        public string TransactionStatusInformation { get; set; }
    }
}
