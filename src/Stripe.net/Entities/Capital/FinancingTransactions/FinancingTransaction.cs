// File generated from our OpenAPI spec
namespace Stripe.Capital
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    /// <summary>
    /// This is an object representing the details of a transaction on a Capital financing
    /// object.
    /// </summary>
    public class FinancingTransaction : StripeEntity<FinancingTransaction>, IHasId, IHasObject
    {
        /// <summary>
        /// A unique identifier for the financing transaction object.
        /// </summary>
        [JsonProperty("id")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("id")]
#endif
        public string Id { get; set; }

        /// <summary>
        /// The object type: financing_transaction.
        /// </summary>
        [JsonProperty("object")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("object")]
#endif
        public string Object { get; set; }

        /// <summary>
        /// The ID of the merchant associated with this financing transaction.
        /// </summary>
        [JsonProperty("account")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("account")]
#endif
        public string Account { get; set; }

        /// <summary>
        /// Time at which the financing transaction was created. Given in seconds since unix epoch.
        /// </summary>
        [JsonProperty("created_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("created_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif
        public DateTime CreatedAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// This is an object representing a transaction on a Capital financing offer.
        /// </summary>
        [JsonProperty("details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("details")]
#endif
        public FinancingTransactionDetails Details { get; set; }

        /// <summary>
        /// The Capital financing offer for this financing transaction.
        /// </summary>
        [JsonProperty("financing_offer")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("financing_offer")]
#endif
        public string FinancingOffer { get; set; }

        /// <summary>
        /// The Capital transaction object that predates the Financing Transactions API and
        /// corresponds with the balance transaction that was created as a result of this financing
        /// transaction.
        /// </summary>
        [JsonProperty("legacy_balance_transaction_source")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("legacy_balance_transaction_source")]
#endif
        public string LegacyBalanceTransactionSource { get; set; }

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
        /// The type of the financing transaction.
        /// One of: <c>payment</c>, <c>payout</c>, or <c>reversal</c>.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }

        /// <summary>
        /// A human-friendly description of the financing transaction.
        /// </summary>
        [JsonProperty("user_facing_description")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("user_facing_description")]
#endif
        public string UserFacingDescription { get; set; }
    }
}
