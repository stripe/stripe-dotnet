// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class SubscriptionScheduleAmendmentAmendmentEndTimestampOptions : INestedOptions
    {
        /// <summary>
        /// A precise numeric timestamp, provided as an integer number of seconds since the Unix
        /// epoch.
        /// </summary>
        [JsonProperty("value")]
        public long? Value { get; set; }
    }
}
