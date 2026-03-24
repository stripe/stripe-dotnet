// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class DisputeListOptions : ListOptions
    {
        /// <summary>
        /// Only return Issuing disputes that were created during the given date interval.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(AnyOfConverter))]
        [STJS.JsonPropertyName("created")]
        [STJS.JsonConverter(typeof(STJAnyOfConverter))]
        public AnyOf<DateTime?, DateRangeOptions> Created { get; set; }

        /// <summary>
        /// Select Issuing disputes with the given status.
        /// One of: <c>expired</c>, <c>lost</c>, <c>submitted</c>, <c>unsubmitted</c>, or
        /// <c>won</c>.
        /// </summary>
        [JsonProperty("status")]
        [STJS.JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// Select the Issuing dispute for the given transaction.
        /// </summary>
        [JsonProperty("transaction")]
        [STJS.JsonPropertyName("transaction")]
        public string Transaction { get; set; }
    }
}
