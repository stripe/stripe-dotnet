// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class SubscriptionSchedulePrebillingBillFromOptions : INestedOptions
    {
        /// <summary>
        /// Start the prebilled period when a specified amendment begins.
        /// </summary>
        [JsonProperty("amendment_start")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amendment_start")]
#endif
        public SubscriptionSchedulePrebillingBillFromAmendmentStartOptions AmendmentStart { get; set; }

        /// <summary>
        /// Start the prebilled period at a precise integer timestamp, starting from the Unix epoch.
        /// </summary>
        [JsonProperty("timestamp")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("timestamp")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif
        public DateTime? Timestamp { get; set; }

        /// <summary>
        /// Select one of several ways to pass the <c>bill_from</c> value.
        /// One of: <c>amendment_start</c>, <c>now</c>, or <c>timestamp</c>.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }
    }
}
