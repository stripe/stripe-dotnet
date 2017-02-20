using System.Collections.Generic;
using Newtonsoft.Json;

namespace Stripe
{
    /// <summary>
    /// Sku listing filters.
    /// </summary>
    public class StripeSkuListOptions : StripeListSelectedOptionsBase
    {
        /// <summary>
        /// Gets or sets a value idicating whether only active or inative skus will be returned.  (e.g. pass false to list all inactive skus).
        /// optional
        /// </summary>
        [JsonProperty("active")]
        public bool? Active { get; set; }

        /// <summary>
        /// Gets or sets partially constructed dictionary containing attributes and values.
        /// Only return SKUs that have the specified key/value pairs in this dictionary. Can be specified only if product is also supplied. For instance, if the associated product has attributes ["color", "size"], passing in attributes[color]=red returns all the SKUs for this product that have color set to red.
        /// Optional
        /// </summary>
        [JsonProperty("attributes")]
        public Dictionary<string, string> Attributes { get; set; }

        /// <summary>
        /// Gets or sets a value idicating whether only items in or out of stock will be returned.  (e.g. pass false to list all out of stock skus).
        /// optional
        /// </summary>
        [JsonProperty("in_stock")]
        public bool? InStock { get; set; }

        /// <summary>
        /// Gets or sets the ID of the product whose SKUs will be retrieved.
        /// Optional
        /// </summary>
        [JsonProperty("product")]
        public string ProductId { get; set; }
    }
}
