using Newtonsoft.Json;

namespace Stripe
{

    public class StripeInventory : INestedNamedOptions
    {
        /// <summary>
        /// v2017-01-27: Gets or sets the count of inventory available. Will be present if and only if Type is finite.
        /// </summary>
        [JsonProperty("quantity")]
        public uint? Quantity { get; set; }

        /// <summary>
        /// v2017-01-27: Gets or sets inventory Type. Possible values are finite, bucket (not quantified), and infinite.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// v2017-01-27: Gets or sets an indicator of the inventory available. Possible values are in_stock, limited, and out_of_stock. Will be present if and only if Type is bucket.
        /// </summary>
        [JsonProperty("value")]
        public string Value { get; set; }
    }
}
