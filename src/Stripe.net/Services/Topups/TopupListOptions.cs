// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class TopupListOptions : ListOptions
    {
        /// <summary>
        /// A positive integer representing how much to transfer.
        /// </summary>
        [JsonProperty("amount")]
        [JsonConverter(typeof(AnyOfConverter))]
        [STJS.JsonPropertyName("amount")]
        [STJS.JsonConverter(typeof(STJAnyOfConverter))]
        public AnyOf<DateTime?, DateRangeOptions> Amount { get; set; }

        /// <summary>
        /// A filter on the list, based on the object <c>created</c> field. The value can be a
        /// string with an integer Unix timestamp, or it can be a dictionary with a number of
        /// different query options.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(AnyOfConverter))]
        [STJS.JsonPropertyName("created")]
        [STJS.JsonConverter(typeof(STJAnyOfConverter))]
        public AnyOf<DateTime?, DateRangeOptions> Created { get; set; }

        /// <summary>
        /// Only return top-ups that have the given status. One of <c>canceled</c>, <c>failed</c>,
        /// <c>pending</c> or <c>succeeded</c>.
        /// One of: <c>canceled</c>, <c>failed</c>, <c>pending</c>, or <c>succeeded</c>.
        /// </summary>
        [JsonProperty("status")]
        [STJS.JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
