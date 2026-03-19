// File generated from our OpenAPI spec
namespace Stripe.V2.Core.Vault
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// Use the GBBankAccounts API to create and manage GB bank account objects.
    /// </summary>
    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class GbBankAccount : StripeEntity<GbBankAccount>, IHasId, IHasObject
    {
        /// <summary>
        /// The ID of the GBBankAccount object.
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
        public GbBankAccountAlternativeReference AlternativeReference { get; set; }

        /// <summary>
        /// Whether this bank account object was archived. Bank account objects can be archived
        /// through the /archive API, and they will not be automatically archived by Stripe.
        /// Archived bank account objects cannot be used as outbound destinations and will not
        /// appear in the outbound destination list.
        /// </summary>
        [JsonProperty("archived")]
        [STJS.JsonPropertyName("archived")]
        public bool Archived { get; set; }

        /// <summary>
        /// Closed Enum. The type of the bank account (checking or savings).
        /// One of: <c>checking</c>, or <c>savings</c>.
        /// </summary>
        [JsonProperty("bank_account_type")]
        [STJS.JsonPropertyName("bank_account_type")]
        public string BankAccountType { get; set; }

        /// <summary>
        /// The name of the bank.
        /// </summary>
        [JsonProperty("bank_name")]
        [STJS.JsonPropertyName("bank_name")]
        public string BankName { get; set; }

        /// <summary>
        /// Information around the status of Confirmation of Payee matching done on this bank
        /// account. Confirmation of Payee is a name matching service that must be done before
        /// making OutboundPayments in the UK.
        /// </summary>
        [JsonProperty("confirmation_of_payee")]
        [STJS.JsonPropertyName("confirmation_of_payee")]
        public GbBankAccountConfirmationOfPayee ConfirmationOfPayee { get; set; }

        /// <summary>
        /// Creation time.
        /// </summary>
        [JsonProperty("created")]
        [STJS.JsonPropertyName("created")]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// The last 4 digits of the account number or IBAN.
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
        /// The Sort Code of the bank account.
        /// </summary>
        [JsonProperty("sort_code")]
        [STJS.JsonPropertyName("sort_code")]
        public string SortCode { get; set; }
    }
}
