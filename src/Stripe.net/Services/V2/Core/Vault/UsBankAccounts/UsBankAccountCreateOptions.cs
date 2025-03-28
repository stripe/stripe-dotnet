// File generated from our OpenAPI spec
namespace Stripe.V2.Core.Vault
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class UsBankAccountCreateOptions : BaseOptions
    {
        /// <summary>
        /// The account number of the bank account.
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
        /// The fedwire routing number of the bank account. Note that certain banks have the same
        /// ACH and wire routing number.
        /// </summary>
        [JsonProperty("fedwire_routing_number")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("fedwire_routing_number")]
#endif
        public string FedwireRoutingNumber { get; set; }

        /// <summary>
        /// The ACH routing number of the bank account. Note that certain banks have the same ACH
        /// and wire routing number.
        /// </summary>
        [JsonProperty("routing_number")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("routing_number")]
#endif
        public string RoutingNumber { get; set; }
    }
}
