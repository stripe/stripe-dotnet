// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class QuoteSubscriptionDataOverrideBillOnAcceptanceBillUntilOptions : INestedOptions
    {
        /// <summary>
        /// Details of the duration over which to bill.
        /// </summary>
        [JsonProperty("duration")]
        public QuoteSubscriptionDataOverrideBillOnAcceptanceBillUntilDurationOptions Duration { get; set; }

        /// <summary>
        /// Details of a Quote line item from which to bill until.
        /// </summary>
        [JsonProperty("line_ends_at")]
        public QuoteSubscriptionDataOverrideBillOnAcceptanceBillUntilLineEndsAtOptions LineEndsAt { get; set; }

        /// <summary>
        /// A precise Unix timestamp.
        /// </summary>
        [JsonProperty("timestamp")]
        public long? Timestamp { get; set; }

        /// <summary>
        /// The type of method to specify the <c>bill_until</c> time.
        /// One of: <c>duration</c>, <c>line_ends_at</c>, <c>schedule_end</c>, <c>timestamp</c>, or
        /// <c>upcoming_invoice</c>.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
