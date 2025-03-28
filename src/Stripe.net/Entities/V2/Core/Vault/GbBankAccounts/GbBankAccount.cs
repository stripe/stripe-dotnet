// File generated from our OpenAPI spec
namespace Stripe.V2.Core.Vault
{
    using System;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    /// <summary>
    /// Use the GbBankAccounts API to create and manage GB bank account objects.
    /// </summary>
    public class GbBankAccount : StripeEntity<GbBankAccount>, IHasId, IHasObject
    {
        /// <summary>
        /// The ID of the GbBankAccount object.
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
        /// Whether this bank account object was archived. Bank account objects can be archived
        /// through the /archive API, and they will not be automatically archived by Stripe.
        /// Archived bank account objects cannot be used as outbound destinations and will not
        /// appear in the outbound destination list.
        /// </summary>
        [JsonProperty("archived")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("archived")]
#endif
        public bool Archived { get; set; }

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
        /// The name of the bank.
        /// </summary>
        [JsonProperty("bank_name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("bank_name")]
#endif
        public string BankName { get; set; }

        /// <summary>
        /// Information around the status of Confirmation of Payee matching done on this bank
        /// account. Confirmation of Payee is a name matching service that must be done before
        /// making OutboundPayments in the UK.
        /// </summary>
        [JsonProperty("confirmation_of_payee")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("confirmation_of_payee")]
#endif
        public GbBankAccountConfirmationOfPayee ConfirmationOfPayee { get; set; }

        /// <summary>
        /// Creation time.
        /// </summary>
        [JsonProperty("created")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("created")]
#endif
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// The last 4 digits of the account number or IBAN.
        /// </summary>
        [JsonProperty("last4")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("last4")]
#endif
        public string Last4 { get; set; }

        /// <summary>
        /// The Sort Code of the bank account.
        /// </summary>
        [JsonProperty("sort_code")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("sort_code")]
#endif
        public string SortCode { get; set; }
    }
}
