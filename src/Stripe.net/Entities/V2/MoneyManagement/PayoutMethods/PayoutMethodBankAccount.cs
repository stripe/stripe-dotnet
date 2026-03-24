// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PayoutMethodBankAccount : StripeEntity<PayoutMethodBankAccount>
    {
        /// <summary>
        /// Whether this PayoutMethodBankAccount object was archived. PayoutMethodBankAccount
        /// objects can be archived through the /archive API, and they will not be automatically
        /// archived by Stripe. Archived PayoutMethodBankAccount objects cannot be used as payout
        /// methods and will not appear in the payout method list.
        /// </summary>
        [JsonProperty("archived")]
        [STJS.JsonPropertyName("archived")]
        public bool Archived { get; set; }

        /// <summary>
        /// The type of bank account (checking or savings).
        /// One of: <c>checking</c>, or <c>savings</c>.
        /// </summary>
        [JsonProperty("bank_account_type")]
        [STJS.JsonPropertyName("bank_account_type")]
        public string BankAccountType { get; set; }

        /// <summary>
        /// The name of the bank this bank account is in. This field is populated automatically by
        /// Stripe.
        /// </summary>
        [JsonProperty("bank_name")]
        [STJS.JsonPropertyName("bank_name")]
        public string BankName { get; set; }

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
        /// List of enabled flows for this bank account (wire or local).
        /// </summary>
        [JsonProperty("enabled_delivery_options")]
        [STJS.JsonPropertyName("enabled_delivery_options")]
        public List<string> EnabledDeliveryOptions { get; set; }

        /// <summary>
        /// The ID of the Financial Connections Account used to create the bank account.
        /// </summary>
        [JsonProperty("financial_connections_account")]
        [STJS.JsonPropertyName("financial_connections_account")]
        public string FinancialConnectionsAccount { get; set; }

        /// <summary>
        /// The last 4 digits of the account number.
        /// </summary>
        [JsonProperty("last4")]
        [STJS.JsonPropertyName("last4")]
        public string Last4 { get; set; }

        /// <summary>
        /// The routing number of the bank account, if present.
        /// </summary>
        [JsonProperty("routing_number")]
        [STJS.JsonPropertyName("routing_number")]
        public string RoutingNumber { get; set; }

        /// <summary>
        /// The list of currencies supported by this bank account.
        /// </summary>
        [JsonProperty("supported_currencies")]
        [STJS.JsonPropertyName("supported_currencies")]
        public List<string> SupportedCurrencies { get; set; }

        /// <summary>
        /// The swift code of the bank or financial institution.
        /// </summary>
        [JsonProperty("swift_code")]
        [STJS.JsonPropertyName("swift_code")]
        public string SwiftCode { get; set; }
    }
}
