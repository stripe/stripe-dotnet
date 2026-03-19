// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class TransactionStatusTransitionsOptions : INestedOptions
    {
        /// <summary>
        /// Returns Transactions with <c>posted_at</c> within the specified range.
        /// </summary>
        [JsonProperty("posted_at")]
        [JsonConverter(typeof(AnyOfConverter))]
        [STJS.JsonPropertyName("posted_at")]
        [STJS.JsonConverter(typeof(STJAnyOfConverter))]
        public AnyOf<DateTime?, DateRangeOptions> PostedAt { get; set; }
    }
}
