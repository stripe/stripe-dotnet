// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// The EarnedCredit object.
    /// </summary>
    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class EarnedCredit : StripeEntity<EarnedCredit>, IHasId, IHasObject
    {
        /// <summary>
        /// Unique identifier for the EarnedCredit.
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
        /// The amount and currency of the EarnedCredit.
        /// </summary>
        [JsonProperty("amount")]
        [STJS.JsonPropertyName("amount")]
        public V2.Amount Amount { get; set; }

        /// <summary>
        /// Time at which the EarnedCredit was created.
        /// </summary>
        [JsonProperty("created")]
        [STJS.JsonPropertyName("created")]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Description of the EarnedCredit.
        /// </summary>
        [JsonProperty("description")]
        [STJS.JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// The FinancialAccount that earned the credit.
        /// </summary>
        [JsonProperty("financial_account")]
        [STJS.JsonPropertyName("financial_account")]
        public string FinancialAccount { get; set; }

        /// <summary>
        /// Has the value true if the object exists in live mode.
        /// </summary>
        [JsonProperty("livemode")]
        [STJS.JsonPropertyName("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// The period during which the credit was earned.
        /// </summary>
        [JsonProperty("period")]
        [STJS.JsonPropertyName("period")]
        public EarnedCreditPeriod Period { get; set; }

        /// <summary>
        /// Details about the revenue share that caused the EarnedCredit.
        /// </summary>
        [JsonProperty("revenue_share")]
        [STJS.JsonPropertyName("revenue_share")]
        public EarnedCreditRevenueShare RevenueShare { get; set; }

        /// <summary>
        /// Details about the reward that caused the EarnedCredit.
        /// </summary>
        [JsonProperty("reward")]
        [STJS.JsonPropertyName("reward")]
        public EarnedCreditReward Reward { get; set; }

        /// <summary>
        /// The status of the EarnedCredit.
        /// One of: <c>succeeded</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("status")]
        [STJS.JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// Timestamps for EarnedCredit status transitions.
        /// </summary>
        [JsonProperty("status_transitions")]
        [STJS.JsonPropertyName("status_transitions")]
        public EarnedCreditStatusTransitions StatusTransitions { get; set; }

        /// <summary>
        /// The type of flow that caused the EarnedCredit.
        /// One of: <c>interest</c>, <c>revenue_share</c>, or <c>reward</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
