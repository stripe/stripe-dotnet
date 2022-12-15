// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class QuoteSubscriptionDataOverrideBillOnAcceptanceBillUntilOptions : INestedOptions
    {
        /// <summary>
        /// Details of a Quote line item from which to bill until.
        /// </summary>
        [JsonProperty("line_starts_at")]
        public QuoteSubscriptionDataOverrideBillOnAcceptanceBillUntilLineStartsAtOptions LineStartsAt { get; set; }

        /// <summary>
        /// Details of a Unix timestamp to bill until.
        /// </summary>
        [JsonProperty("timestamp")]
        public QuoteSubscriptionDataOverrideBillOnAcceptanceBillUntilTimestampOptions Timestamp { get; set; }

        /// <summary>
        /// The type of method to specify the <c>bill_until</c> time.
        /// One of: <c>duration</c>, <c>line_ends_at</c>, <c>schedule_end</c>, <c>timestamp</c>, or
        /// <c>upcoming_invoice</c>.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
