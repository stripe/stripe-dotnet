// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class SubscriptionSchedulePrebillingBillFromOptions : INestedOptions
    {
        /// <summary>
        /// Start the prebilled period when a specified amendment begins.
        /// </summary>
        [JsonProperty("amendment_start")]
        public SubscriptionSchedulePrebillingBillFromAmendmentStartOptions AmendmentStart { get; set; }

        /// <summary>
        /// Start the prebilled period at a precise integer timestamp, starting from the Unix epoch.
        /// </summary>
        [JsonProperty("timestamp")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? Timestamp { get; set; }

        /// <summary>
        /// Select one of several ways to pass the <c>bill_from</c> value.
        /// One of: <c>amendment_start</c>, <c>now</c>, or <c>timestamp</c>.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
