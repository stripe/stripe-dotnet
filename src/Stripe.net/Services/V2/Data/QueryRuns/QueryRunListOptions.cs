// File generated from our OpenAPI spec
namespace Stripe.V2.Data
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class QueryRunListOptions : V2.ListOptions
    {
        /// <summary>
        /// If supplied, only return query runs created within this time range.
        /// </summary>
        [JsonProperty("created")]
        [STJS.JsonPropertyName("created")]
        public QueryRunListCreatedOptions Created { get; set; }

        /// <summary>
        /// If supplied, only return query runs that have any of these statuses.
        /// One of: <c>canceled</c>, <c>failed</c>, <c>running</c>, or <c>succeeded</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("statuses")]
        [STJS.JsonPropertyName("statuses")]
        public List<string> Statuses { get; set; }
    }
}
