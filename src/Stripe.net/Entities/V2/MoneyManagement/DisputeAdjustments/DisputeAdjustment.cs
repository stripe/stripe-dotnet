// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// A DisputeAdjustment records a money movement associated with a Dispute.
    /// </summary>
    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class DisputeAdjustment : StripeEntity<DisputeAdjustment>, IHasId, IHasObject
    {
        /// <summary>
        /// Unique identifier for the DisputeAdjustment.
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
        /// The amount and currency of the DisputeAdjustment.
        /// </summary>
        [JsonProperty("amount")]
        [STJS.JsonPropertyName("amount")]
        public V2.Amount Amount { get; set; }

        /// <summary>
        /// The time at which the DisputeAdjustment was created.
        /// </summary>
        [JsonProperty("created")]
        [STJS.JsonPropertyName("created")]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// The ID of the FinancialAccount associated with the DisputeAdjustment.
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

        /// <summary>
        /// The Dispute associated with this DisputeAdjustment.
        /// </summary>
        [JsonProperty("related_dispute")]
        [STJS.JsonPropertyName("related_dispute")]
        public DisputeAdjustmentRelatedDispute RelatedDispute { get; set; }
    }
}
