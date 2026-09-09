// File generated from our OpenAPI spec
namespace Stripe.ProductCatalog
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class TrialOfferListOptions : ListOptions
    {
        /// <summary>
        /// Only return trial offers that are active (<c>true</c>) or archived (<c>false</c>). If
        /// omitted, both active and archived trial offers are returned.
        /// </summary>
        [JsonProperty("active")]
        [STJS.JsonPropertyName("active")]
        public bool? Active { get; set; }

        /// <summary>
        /// Only return trial offers that were created during the given date interval.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(AnyOfConverter))]
        [STJS.JsonPropertyName("created")]
        [STJS.JsonConverter(typeof(STJAnyOfConverter))]
        public AnyOf<DateTime?, DateRangeOptions> Created { get; set; }

        /// <summary>
        /// Only return trial offers that reference these prices (during the trial period).
        /// </summary>
        [JsonProperty("prices")]
        [STJS.JsonPropertyName("prices")]
        public List<string> Prices { get; set; }
    }
}
