using Newtonsoft.Json;

namespace Stripe
{
    public class StripeOutcome : StripeEntityWithId
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
        /// An enumerated value indicating a more detailed explanation of the outcome’s type. See understanding declines for details.
        /// </summary>
        [JsonProperty("rule")]
        public string Rule { get; set; }

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
