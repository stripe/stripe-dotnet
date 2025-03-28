// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class OutboundSetupIntentCreatePayoutMethodDataBankAccountOptions : INestedOptions
    {
        /// <summary>
        /// The account number or IBAN of the bank account.
        /// </summary>
        [JsonProperty("account_number")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("account_number")]
#endif
        public string AccountNumber { get; set; }

        /// <summary>
        /// Closed Enum. The type of the bank account (checking or savings).
        /// One of: <c>checking</c>, or <c>savings</c>.
        /// </summary>
        [JsonProperty("bank_account_type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("bank_account_type")]
#endif
        public string BankAccountType { get; set; }

        /// <summary>
        /// The branch number of the bank account, if present.
        /// </summary>
        [JsonProperty("branch_number")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("branch_number")]
#endif
        public string BranchNumber { get; set; }

        /// <summary>
        /// The country code of the bank account.
        /// </summary>
        [JsonProperty("country")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("country")]
#endif
        public string Country { get; set; }

        /// <summary>
        /// The routing number of the bank account, if present.
        /// </summary>
        [JsonProperty("routing_number")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("routing_number")]
#endif
        public string RoutingNumber { get; set; }

        /// <summary>
        /// The swift code of the bank account, if present.
        /// </summary>
        [JsonProperty("swift_code")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("swift_code")]
#endif
        public string SwiftCode { get; set; }
    }
}
