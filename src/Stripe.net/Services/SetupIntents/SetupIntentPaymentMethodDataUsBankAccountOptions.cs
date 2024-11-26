// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class SetupIntentPaymentMethodDataUsBankAccountOptions : INestedOptions
    {
        /// <summary>
        /// Account holder type: individual or company.
        /// One of: <c>company</c>, or <c>individual</c>.
        /// </summary>
        [JsonProperty("account_holder_type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("account_holder_type")]
#endif
        public string AccountHolderType { get; set; }

        /// <summary>
        /// Account number of the bank account.
        /// </summary>
        [JsonProperty("account_number")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("account_number")]
#endif
        public string AccountNumber { get; set; }

        /// <summary>
        /// Account type: checkings or savings. Defaults to checking if omitted.
        /// One of: <c>checking</c>, or <c>savings</c>.
        /// </summary>
        [JsonProperty("account_type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("account_type")]
#endif
        public string AccountType { get; set; }

        /// <summary>
        /// The ID of a Financial Connections Account to use as a payment method.
        /// </summary>
        [JsonProperty("financial_connections_account")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("financial_connections_account")]
#endif
        public string FinancialConnectionsAccount { get; set; }

        /// <summary>
        /// Routing number of the bank account.
        /// </summary>
        [JsonProperty("routing_number")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("routing_number")]
#endif
        public string RoutingNumber { get; set; }
    }
}
