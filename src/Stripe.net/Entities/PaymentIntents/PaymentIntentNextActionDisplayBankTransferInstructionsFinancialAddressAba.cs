// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentIntentNextActionDisplayBankTransferInstructionsFinancialAddressAba : StripeEntity<PaymentIntentNextActionDisplayBankTransferInstructionsFinancialAddressAba>
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

        /// <summary>
        /// The ABA account number.
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
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("account_type")]
#endif
        public string AccountType { get; set; }

        [JsonProperty("bank_address")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("bank_address")]
#endif
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
        /// The ABA routing number.
        /// </summary>
        [JsonProperty("routing_number")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("routing_number")]
#endif
        public string RoutingNumber { get; set; }
    }
}
