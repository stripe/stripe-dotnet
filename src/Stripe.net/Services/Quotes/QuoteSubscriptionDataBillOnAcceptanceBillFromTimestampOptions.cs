// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class QuoteSubscriptionDataBillOnAcceptanceBillFromTimestampOptions : INestedOptions
    {
        /// <summary>
        /// A precise Unix timestamp.
        /// </summary>
        [JsonProperty("timestamp")]
        public long? Timestamp { get; set; }
    }
}
