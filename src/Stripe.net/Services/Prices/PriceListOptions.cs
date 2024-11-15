// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PriceListOptions : ListOptionsWithCreated
    {
        /// <summary>
        /// Only return prices that are active or inactive (e.g., pass <c>false</c> to list all
        /// inactive prices).
        /// </summary>
        [JsonProperty("active")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("active")]
#endif

        public bool? Active { get; set; }

        /// <summary>
        /// Only return prices for the given currency.
        /// </summary>
        [JsonProperty("currency")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("currency")]
#endif

        public string Currency { get; set; }

        /// <summary>
        /// Only return the price with these lookup_keys, if any exist. You can specify up to 10
        /// lookup_keys.
        /// </summary>
        [JsonProperty("lookup_keys")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("lookup_keys")]
#endif

        public List<string> LookupKeys { get; set; }

        /// <summary>
        /// Only return prices for the given product.
        /// </summary>
        [JsonProperty("product")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("product")]
#endif

        public string Product { get; set; }

        /// <summary>
        /// Only return prices with these recurring fields.
        /// </summary>
        [JsonProperty("recurring")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("recurring")]
#endif

        public PriceRecurringListOptions Recurring { get; set; }

        /// <summary>
        /// Only return prices of type <c>recurring</c> or <c>one_time</c>.
        /// One of: <c>one_time</c>, or <c>recurring</c>.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif

        public string Type { get; set; }
    }
}
