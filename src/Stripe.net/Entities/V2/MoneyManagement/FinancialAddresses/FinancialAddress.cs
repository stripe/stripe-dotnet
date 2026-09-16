// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// A FinancialAddress contains information needed to transfer money to a Financial Account.
    /// A Financial Account can have more than one Financial Address.
    /// </summary>
    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class FinancialAddress : StripeEntity<FinancialAddress>, IHasId, IHasObject
    {
        /// <summary>
        /// The ID of the FinancialAddress.
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
        /// Bank account details for this FinancialAddress.
        /// </summary>
        [JsonProperty("bank_account")]
        [STJS.JsonPropertyName("bank_account")]
        public FinancialAddressBankAccount BankAccount { get; set; }

        /// <summary>
        /// The creation timestamp of the FinancialAddress.
        /// </summary>
        [JsonProperty("created")]
        [STJS.JsonPropertyName("created")]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        [JsonProperty("crypto_wallet")]
        [STJS.JsonPropertyName("crypto_wallet")]
        public FinancialAddressCryptoWallet CryptoWallet { get; set; }

        /// <summary>
        /// The ID of the FinancialAccount this FinancialAddress corresponds to.
        /// </summary>
        [JsonProperty("financial_account")]
        [STJS.JsonPropertyName("financial_account")]
        public string FinancialAccount { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
        [STJS.JsonPropertyName("livemode")]
        public bool Livemode { get; set; }

        [JsonProperty("settlement_currency")]
        [STJS.JsonPropertyName("settlement_currency")]
        public string SettlementCurrency { get; set; }

        /// <summary>
        /// Closed Enum. The status of the FinancialAddress.
        /// One of: <c>active</c>, <c>archived</c>, <c>failed</c>, or <c>pending</c>.
        /// </summary>
        [JsonProperty("status")]
        [STJS.JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// Open Enum. The type of FinancialAddress.
        /// One of: <c>bank_account</c>, or <c>crypto_wallet</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
