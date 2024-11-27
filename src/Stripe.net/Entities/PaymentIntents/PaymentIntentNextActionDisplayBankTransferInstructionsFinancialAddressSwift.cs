// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentIntentNextActionDisplayBankTransferInstructionsFinancialAddressSwift : StripeEntity<PaymentIntentNextActionDisplayBankTransferInstructionsFinancialAddressSwift>
    {
        [JsonProperty("account_holder_address")]
        public Address AccountHolderAddress { get; set; }

        /// <summary>
        /// The account holder name.
        /// </summary>
        [JsonProperty("account_holder_name")]
        public string AccountHolderName { get; set; }

        /// <summary>
        /// The account number.
        /// </summary>
        [JsonProperty("account_number")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("account_number")]
#endif
        public string AccountNumber { get; set; }

        /// <summary>
        /// The account type.
        /// </summary>
        [JsonProperty("account_type")]
        public string AccountType { get; set; }

        [JsonProperty("bank_address")]
        public Address BankAddress { get; set; }

        /// <summary>
        /// The bank name.
        /// </summary>
        [JsonProperty("bank_name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("bank_name")]
#endif
        public string BankName { get; set; }

        /// <summary>
        /// The SWIFT code.
        /// </summary>
        [JsonProperty("swift_code")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("swift_code")]
#endif
        public string SwiftCode { get; set; }
    }
}
