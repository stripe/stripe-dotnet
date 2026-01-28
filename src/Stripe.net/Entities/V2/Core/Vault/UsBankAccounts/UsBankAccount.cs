// File generated from our OpenAPI spec
namespace Stripe.V2.Core.Vault
{
    using System;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    /// <summary>
    /// Use the USBankAccounts API to create and manage US bank accounts objects that you can
    /// use to receive funds. Note that these are not interchangeable with v1 Tokens.
    /// </summary>
    public class UsBankAccount : StripeEntity<UsBankAccount>, IHasId, IHasObject
    {
        /// <summary>
        /// The ID of the USBankAccount object.
        /// </summary>
        [JsonProperty("id")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("id")]
#endif
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value of
        /// the object field.
        /// </summary>
        [JsonProperty("object")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("object")]
#endif
        public string Object { get; set; }

        /// <summary>
        /// The alternative reference for this payout method, if it's a projected payout method.
        /// </summary>
        [JsonProperty("alternative_reference")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("alternative_reference")]
#endif
        public UsBankAccountAlternativeReference AlternativeReference { get; set; }

        /// <summary>
        /// Whether this USBankAccount object was archived.
        /// </summary>
        [JsonProperty("archived")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("archived")]
#endif
        public bool Archived { get; set; }

        /// <summary>
        /// Closed Enum. The type of bank account (checking or savings).
        /// One of: <c>checking</c>, or <c>savings</c>.
        /// </summary>
        [JsonProperty("bank_account_type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("bank_account_type")]
#endif
        public string BankAccountType { get; set; }

        /// <summary>
        /// The name of the bank this bank account belongs to. This field is populated automatically
        /// by Stripe based on the routing number.
        /// </summary>
        [JsonProperty("bank_name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("bank_name")]
#endif
        public string BankName { get; set; }

        /// <summary>
        /// Creation time of the object.
        /// </summary>
        [JsonProperty("created")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("created")]
#endif
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// The fedwire routing number of the bank account.
        /// </summary>
        [JsonProperty("fedwire_routing_number")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("fedwire_routing_number")]
#endif
        public string FedwireRoutingNumber { get; set; }

        /// <summary>
        /// The ID of the Financial Connections Account used to create the bank account.
        /// </summary>
        [JsonProperty("financial_connections_account")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("financial_connections_account")]
#endif
        public string FinancialConnectionsAccount { get; set; }

        /// <summary>
        /// The last 4 digits of the account number.
        /// </summary>
        [JsonProperty("last4")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("last4")]
#endif
        public string Last4 { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("livemode")]
#endif
        public bool Livemode { get; set; }

        /// <summary>
        /// The ACH routing number of the bank account.
        /// </summary>
        [JsonProperty("routing_number")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("routing_number")]
#endif
        public string RoutingNumber { get; set; }

        /// <summary>
        /// The bank account verification details.
        /// </summary>
        [JsonProperty("verification")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("verification")]
#endif
        public UsBankAccountVerification Verification { get; set; }
    }
}
