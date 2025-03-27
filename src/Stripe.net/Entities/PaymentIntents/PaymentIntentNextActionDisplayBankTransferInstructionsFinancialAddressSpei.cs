// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentIntentNextActionDisplayBankTransferInstructionsFinancialAddressSpei : StripeEntity<PaymentIntentNextActionDisplayBankTransferInstructionsFinancialAddressSpei>
    {
        [JsonProperty("account_holder_address")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("account_holder_address")]
#endif
        public Address AccountHolderAddress { get; set; }

        /// <summary>
        /// The account holder name.
        /// </summary>
        [JsonProperty("account_holder_name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("account_holder_name")]
#endif
        public string AccountHolderName { get; set; }

        [JsonProperty("bank_address")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("bank_address")]
#endif
        public Address BankAddress { get; set; }

        /// <summary>
        /// The three-digit bank code.
        /// </summary>
        [JsonProperty("bank_code")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("bank_code")]
#endif
        public string BankCode { get; set; }

        /// <summary>
        /// The short banking institution name.
        /// </summary>
        [JsonProperty("bank_name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("bank_name")]
#endif
        public string BankName { get; set; }

        /// <summary>
        /// The CLABE number.
        /// </summary>
        [JsonProperty("clabe")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("clabe")]
#endif
        public string Clabe { get; set; }
    }
}
