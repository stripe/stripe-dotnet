// File generated from our OpenAPI spec
namespace Stripe.V2.Core.Vault
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class UsBankAccountCreateOptions : BaseOptions
    {
        /// <summary>
        /// The account number of the bank account.
        /// </summary>
        [JsonProperty("account_number")]
        [STJS.JsonPropertyName("account_number")]
        public string AccountNumber { get; set; }

        /// <summary>
        /// Closed Enum. The type of the bank account (checking or savings).
        /// One of: <c>checking</c>, or <c>savings</c>.
        /// </summary>
        [JsonProperty("bank_account_type")]
        [STJS.JsonPropertyName("bank_account_type")]
        public string BankAccountType { get; set; }

        /// <summary>
        /// The currency of the bank account.
        /// </summary>
        [JsonProperty("currency")]
        [STJS.JsonPropertyName("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// The fedwire routing number of the bank account. Note that certain banks have the same
        /// ACH and wire routing number.
        /// </summary>
        [JsonProperty("fedwire_routing_number")]
        [STJS.JsonPropertyName("fedwire_routing_number")]
        public string FedwireRoutingNumber { get; set; }

        /// <summary>
        /// The ACH routing number of the bank account. Note that certain banks have the same ACH
        /// and wire routing number.
        /// </summary>
        [JsonProperty("routing_number")]
        [STJS.JsonPropertyName("routing_number")]
        public string RoutingNumber { get; set; }
    }
}
