// File generated from our OpenAPI spec
namespace Stripe.V2.Core.Vault
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// Use the USBankAccounts API to create and manage US bank accounts objects that you can
    /// use to receive funds. Note that these are not interchangeable with v1 Tokens.
    /// </summary>
    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class UsBankAccount : StripeEntity<UsBankAccount>, IHasId, IHasObject
    {
        /// <summary>
        /// The ID of the USBankAccount object.
        /// </summary>
        [JsonProperty("id")]
        [STJS.JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value of
        /// the object field.
        /// </summary>
        [JsonProperty("object")]
        [STJS.JsonPropertyName("object")]
        public string Object { get; set; }

        /// <summary>
        /// The alternative reference for this payout method, if it's a projected payout method.
        /// </summary>
        [JsonProperty("alternative_reference")]
        [STJS.JsonPropertyName("alternative_reference")]
        public UsBankAccountAlternativeReference AlternativeReference { get; set; }

        /// <summary>
        /// Whether this USBankAccount object was archived.
        /// </summary>
        [JsonProperty("archived")]
        [STJS.JsonPropertyName("archived")]
        public bool Archived { get; set; }

        /// <summary>
        /// Closed Enum. The type of bank account (checking or savings).
        /// One of: <c>checking</c>, or <c>savings</c>.
        /// </summary>
        [JsonProperty("bank_account_type")]
        [STJS.JsonPropertyName("bank_account_type")]
        public string BankAccountType { get; set; }

        /// <summary>
        /// The name of the bank this bank account belongs to. This field is populated automatically
        /// by Stripe based on the routing number.
        /// </summary>
        [JsonProperty("bank_name")]
        [STJS.JsonPropertyName("bank_name")]
        public string BankName { get; set; }

        /// <summary>
        /// Creation time of the object.
        /// </summary>
        [JsonProperty("created")]
        [STJS.JsonPropertyName("created")]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// The fedwire routing number of the bank account.
        /// </summary>
        [JsonProperty("fedwire_routing_number")]
        [STJS.JsonPropertyName("fedwire_routing_number")]
        public string FedwireRoutingNumber { get; set; }

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
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
        [STJS.JsonPropertyName("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// The ACH routing number of the bank account.
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
        /// The bank account verification details.
        /// </summary>
        [JsonProperty("verification")]
        [STJS.JsonPropertyName("verification")]
        public UsBankAccountVerification Verification { get; set; }
    }
}
