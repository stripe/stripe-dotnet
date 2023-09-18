// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class TopupListOptions : ListOptionsWithCreated
    {
        /// <summary>
        /// A positive integer representing how much to transfer.
        /// </summary>
        [JsonProperty("amount")]
        [JsonConverter(typeof(AnyOfConverter))]
        public AnyOf<DateTime?, DateRangeOptions> Amount { get; set; }

        /// <summary>
        /// Only return top-ups that have the given status. One of <c>canceled</c>, <c>failed</c>,
        /// <c>pending</c> or <c>succeeded</c>.
        /// One of: <c>canceled</c>, <c>failed</c>, <c>pending</c>, or <c>succeeded</c>.
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }
    }
}
