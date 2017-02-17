using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Stripe.Infrastructure;

namespace Stripe
{
    public class StripeSku : StripeEntityWithId
    {
        /// <summary>
        /// Gets or sets  the object Type
        /// </summary>
        [JsonProperty("object")]
        public string Object { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether or not the SKU is available for purchase.
        /// </summary>
        [JsonProperty("active")]
        public bool Active { get; set; }

        /// <summary>
        /// Gets or sets a dictionary of attributes and values for the attributes defined by the product. If, for example, a product’s attributes are ["size", "gender"], a valid SKU has the following dictionary of attributes: {"size": "Medium", "gender": "Unisex"}.
        /// </summary>
        [JsonProperty("attributes")]
        public Dictionary<string, string> Attributes { get; set; }

        /// <summary>
        /// Gets or sets the creation time
        /// </summary>
        [JsonConverter(typeof(StripeDateTimeConverter))]
        [JsonProperty("created")]
        public DateTime Created { get; set; }

        /// <summary>
        /// Gets or sets a 3-letter ISO code for currency.
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// Gets or sets the URL of an image for this SKU, meant to be displayable to the customer.
        /// </summary>
        [JsonProperty("image")]
        public string Image { get; set; }

        /// <summary>
        /// Gets or sets description of the SKU’s inventory.
        /// </summary>
        [JsonProperty("inventory")]
        public StripeInventory Inventory { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the SKU is in live mode.
        /// </summary>
        [JsonProperty("livemode")]
        public bool LiveMode { get; set; }

        /// <summary>
        /// Gets or sets a set of key/value pairs that you can attach to a SKU object. It can be useful for storing additional information about the SKU in a structured format.
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Gets or sets the dimensions of this SKU for shipping purposes.
        /// </summary>
        [JsonProperty("package_dimensions")]
        public StripeDimensions PackageDimensions { get; set; }

        /// <summary>
        /// Gets or sets the cost of the item as a positive integer in the smallest currency unit (that is, 100 cents to charge $1.00, or 100 to charge ¥100, Japanese Yen being a 0-decimal currency).
        /// </summary>
        [JsonProperty("price")]
        public uint Price { get; set; }

        #region Expandable Product
        /// <summary>
        /// Gets or sets the ID of the product this SKU is associated with. The product must be currently active.
        /// EXPANDABLE
        /// </summary>
        public string ProductId { get; set; }

        [JsonIgnore]
        public StripeProduct Product { get; set; }

        [JsonProperty("product")]
        internal object InternalProduct
        {
            set
            {
                ExpandableProperty<StripeProduct>.Map(value, s => ProductId = s, o => Product = o);
            }
        }
        #endregion

        /// <summary>
        /// Gets or sets the update time
        /// </summary>
        [JsonConverter(typeof(StripeDateTimeConverter))]
        [JsonProperty("updated")]
        public DateTime Updated { get; set; }
    }
}
