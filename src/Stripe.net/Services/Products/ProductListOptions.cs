// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class ProductListOptions : ListOptions
    {
        /// <summary>
        /// Only return products that are active or inactive (e.g., pass <c>false</c> to list all
        /// inactive products).
        /// </summary>
        [JsonProperty("active")]
        [STJS.JsonPropertyName("active")]
        public bool? Active { get; set; }

        /// <summary>
        /// Only return products that were created during the given date interval.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(AnyOfConverter))]
        [STJS.JsonPropertyName("created")]
        [STJS.JsonConverter(typeof(STJAnyOfConverter))]
        public AnyOf<DateTime?, DateRangeOptions> Created { get; set; }

        /// <summary>
        /// Only return products with the given IDs. Cannot be used with <a
        /// href="https://api.stripe.com#list_products-starting_after">starting_after</a> or <a
        /// href="https://api.stripe.com#list_products-ending_before">ending_before</a>.
        /// </summary>
        [JsonProperty("ids")]
        [STJS.JsonPropertyName("ids")]
        public List<string> Ids { get; set; }

        /// <summary>
        /// Only return products that can be shipped (i.e., physical, not digital products).
        /// </summary>
        [JsonProperty("shippable")]
        [STJS.JsonPropertyName("shippable")]
        public bool? Shippable { get; set; }

        /// <summary>
        /// Only return products of this type.
        /// One of: <c>good</c>, or <c>service</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// Only return products with the given url.
        /// </summary>
        [JsonProperty("url")]
        [STJS.JsonPropertyName("url")]
        public string Url { get; set; }
    }
}
