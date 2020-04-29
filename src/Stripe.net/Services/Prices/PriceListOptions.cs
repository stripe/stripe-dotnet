namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class PriceListOptions : ListOptionsWithCreated
    {
        /// <summary>
        /// Only return prices that are active or inactive.
        /// </summary>
        [JsonProperty("active")]
        public bool? Active { get; set; }

        /// <summary>
        /// Only return prices for the given currency.
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// Only return the price with these lookup keys, if any exist.
        /// </summary>
        [JsonProperty("lookup_keys")]
        public List<string> LookupKeys { get; set; }

        /// <summary>
        /// Only return prices for the given product.
        /// </summary>
        [JsonProperty("product")]
        public string Product { get; set; }

        /// <summary>
        /// Only return prices with these recurring fields.
        /// </summary>
        [JsonProperty("recurring")]
        public PriceRecurringListOptions Recurring { get; set; }

        /// <summary>
        /// Only return prices of type <c>recurring</c> or <c>one_time</c>.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
