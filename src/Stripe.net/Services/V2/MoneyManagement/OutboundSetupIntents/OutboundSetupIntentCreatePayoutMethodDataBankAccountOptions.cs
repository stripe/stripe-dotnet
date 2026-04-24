// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class OutboundSetupIntentCreatePayoutMethodDataBankAccountOptions : INestedOptions
    {
        /// <summary>
        /// The account number or IBAN of the bank account.
        /// </summary>
        [JsonProperty("account_number")]
        [STJS.JsonPropertyName("account_number")]
        public string AccountNumber { get; set; }

        /// <summary>
        /// Closed Enum. The type of the bank account (checking or savings).
        /// One of: <c>checking</c>, <c>futsu</c>, <c>savings</c>, or <c>toza</c>.
        /// </summary>
        [JsonProperty("bank_account_type")]
        [STJS.JsonPropertyName("bank_account_type")]
        public string BankAccountType { get; set; }

        /// <summary>
        /// The branch number of the bank account, if present.
        /// </summary>
        [JsonProperty("branch_number")]
        [STJS.JsonPropertyName("branch_number")]
        public string BranchNumber { get; set; }

        /// <summary>
        /// The country code of the bank account.
        /// </summary>
        [JsonProperty("country")]
        [STJS.JsonPropertyName("country")]
        public string Country { get; set; }

        /// <summary>
        /// The currency of the bank account.
        /// </summary>
        [JsonProperty("currency")]
        [STJS.JsonPropertyName("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// The routing number of the bank account, if present.
        /// </summary>
        [JsonProperty("routing_number")]
        [STJS.JsonPropertyName("routing_number")]
        public string RoutingNumber { get; set; }

        /// <summary>
        /// The swift code of the bank account, if present.
        /// </summary>
        [JsonProperty("swift_code")]
        [STJS.JsonPropertyName("swift_code")]
        public string SwiftCode { get; set; }
    }
}
