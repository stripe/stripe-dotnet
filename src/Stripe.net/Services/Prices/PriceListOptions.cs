// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class PriceListOptions : ListOptions
    {
        /// <summary>
        /// Only return prices that are active or inactive (e.g., pass <c>false</c> to list all
        /// inactive prices).
        /// </summary>
        [JsonProperty("active")]
        [STJS.JsonPropertyName("active")]
        public bool? Active { get; set; }

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
        /// Only return prices for the given currency.
        /// </summary>
        [JsonProperty("currency")]
        [STJS.JsonPropertyName("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// Only return the price with these lookup_keys, if any exist. You can specify up to 10
        /// lookup_keys.
        /// </summary>
        [JsonProperty("lookup_keys")]
        [STJS.JsonPropertyName("lookup_keys")]
        public List<string> LookupKeys { get; set; }

        /// <summary>
        /// Only return prices for the given product.
        /// </summary>
        [JsonProperty("product")]
        [STJS.JsonPropertyName("product")]
        public string Product { get; set; }

        /// <summary>
        /// Only return prices with these recurring fields.
        /// </summary>
        [JsonProperty("recurring")]
        [STJS.JsonPropertyName("recurring")]
        public PriceRecurringListOptions Recurring { get; set; }

        /// <summary>
        /// Only return prices of type <c>recurring</c> or <c>one_time</c>.
        /// One of: <c>one_time</c>, or <c>recurring</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
