// File generated from our OpenAPI spec
namespace Stripe.V2.Data
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class ReportRunListOptions : V2.ListOptions
    {
        /// <summary>
        /// If supplied, only return report runs created within this time range.
        /// </summary>
        [JsonProperty("created")]
        [STJS.JsonPropertyName("created")]
        public ReportRunListCreatedOptions Created { get; set; }

        /// <summary>
        /// If supplied, only return report runs of the <c>Report</c> with this ID.
        /// </summary>
        [JsonProperty("report")]
        [STJS.JsonPropertyName("report")]
        public string Report { get; set; }

        /// <summary>
        /// If supplied, only return report runs that have any of these statuses.
        /// One of: <c>canceled</c>, <c>failed</c>, <c>running</c>, or <c>succeeded</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("statuses")]
        [STJS.JsonPropertyName("statuses")]
        public List<string> Statuses { get; set; }
    }
}
