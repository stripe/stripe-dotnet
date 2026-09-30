// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class InvoiceSubscriptionDetailsBillingCycleAnchorOptions : INestedOptions
    {
        /// <summary>
        /// A timestamp to use as the subscription's billing cycle anchor. Only valid when
        /// <c>type</c> is <c>timestamp</c>.
        /// </summary>
        [JsonProperty("timestamp")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("timestamp")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime? Timestamp { get; set; }

        /// <summary>
        /// Determines how the subscription's billing cycle anchor behaves for the invoice preview.
        /// One of: <c>now</c>, <c>timestamp</c>, or <c>unchanged</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
