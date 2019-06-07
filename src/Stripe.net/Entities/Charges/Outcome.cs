namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class Outcome : StripeEntity<Outcome>
    {
        /// <summary>
        /// Possible values are approved_by_network, declined_by_network, not_sent_to_network, and reversed_after_approval. The value reversed_after_approval indicates the payment was blocked by Stripe after bank authorization, and may temporarily appear as “pending” on a cardholder’s statement.
        /// </summary>
        [JsonProperty("network_status")]
        public string NetworkStatus { get; set; }

        /// <summary>
        /// An enumerated value indicating a more detailed explanation of the outcome’s type. See understanding declines for details.
        /// </summary>
        [JsonProperty("reason")]
        public string Reason { get; set; }

        /// <summary>
        /// An enumerated value indicating a more detailed explanation of the outcome’s type. See understanding declines for details.
        /// </summary>
        [JsonProperty("risk_level")]
        public string RiskLevel { get; set; }

        /// <summary>
        /// Stripe’s evaluation of the riskiness of the payment. Possible values for evaluated payments are between 0 and 100.
        /// </summary>
        [JsonProperty("risk_score")]
        public long RiskScore { get; set; }

        #region Expandable Rule

        /// <summary>
        /// The ID of the Radar rule that matched the payment, if applicable.
        /// </summary>
        [JsonIgnore]
        public string RuleId => this.InternalRule.Id;

        [JsonIgnore]
        public OutcomeRule Rule => this.InternalRule.ExpandedObject;

        [JsonProperty("rule")]
        [JsonConverter(typeof(ExpandableFieldConverter<OutcomeRule>))]
        internal ExpandableField<OutcomeRule> InternalRule { get; set; }
        #endregion

        /// <summary>
        /// A human-readable description of the outcome type and reason, designed for you (the recipient of the payment), not your customer.
        /// </summary>
        [JsonProperty("seller_message")]
        public string SellerMessage { get; set; }

        /// <summary>
        /// Possible values are authorized, issuer_declined, blocked, and invalid. See understanding declines for details.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
