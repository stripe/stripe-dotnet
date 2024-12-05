// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class ProductListOptions : ListOptionsWithCreated
    {
        /// <summary>
        /// Only return products that are active or inactive (e.g., pass <c>false</c> to list all
        /// inactive products).
        /// </summary>
        [JsonProperty("active")]
        public bool? Active { get; set; }

        /// <summary>
        /// Only return products with the given IDs. Cannot be used with <a
        /// href="https://stripe.com/docs/api#list_products-starting_after">starting_after</a> or <a
        /// href="https://stripe.com/docs/api#list_products-ending_before">ending_before</a>.
        /// </summary>
        [JsonProperty("ids")]
        public List<string> Ids { get; set; }

        /// <summary>
        /// Only return products that can be shipped (i.e., physical, not digital products).
        /// </summary>
        [JsonProperty("shippable")]
        public bool? Shippable { get; set; }

        /// <summary>
        /// Only return products of this type.
        /// One of: <c>good</c>, or <c>service</c>.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// Only return products with the given url.
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }
    }
}
