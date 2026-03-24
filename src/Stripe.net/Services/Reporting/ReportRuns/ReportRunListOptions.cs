// File generated from our OpenAPI spec
namespace Stripe.Reporting
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class ReportRunListOptions : ListOptions
    {
        /// <summary>
        /// Only return Report Runs that were created during the given date interval.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(AnyOfConverter))]
        [STJS.JsonPropertyName("created")]
        [STJS.JsonConverter(typeof(STJAnyOfConverter))]
        public AnyOf<DateTime?, DateRangeOptions> Created { get; set; }
    }
}
