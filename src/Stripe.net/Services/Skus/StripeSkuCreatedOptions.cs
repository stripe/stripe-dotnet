using System.Collections.Generic;
using Newtonsoft.Json;

namespace Stripe
{
    public class StripeSkuCreateOptions : StripeSkuOptionsBase
    {
        /// <summary>
        /// Gets or sets the identifier for the SKU. Must be unique. If not provided, an identifier will be randomly generated.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets a dictionary of attributes and values for the attributes defined by the product. If, for example, a product’s attributes are ["size", "gender"], a valid SKU has the following dictionary of attributes: {"size": "Medium", "gender": "Unisex"}.
        /// </summary>
        [JsonProperty("attributes")]
        public Dictionary<string, string> Attributes { get; set; }

        /// <summary>
        /// Gets or sets the cost of the item as a nonnegative integer in the smallest currency unit (that is, 100 cents to charge $1.00, or 100 to charge ¥100, Japanese Yen being a 0-decimal currency).
        /// </summary>
        [JsonProperty("price")]
        public uint Price { get; set; }
    }
}
