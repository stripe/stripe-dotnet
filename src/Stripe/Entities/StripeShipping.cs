using Newtonsoft.Json;

namespace Stripe
{
    /// <summary>
    /// Shipping details
    /// </summary>
    public class StripeShipping
    {
        /// <summary>
        /// Gets or sets the shipping address for the order. Present if the order is for goods to be shipped.
        /// </summary>
        [JsonProperty("address")]
        public StripeAddress Address { get; set; }

        /// <summary>
        /// Gets or sets the customer name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the customer phone (including extension).
        /// </summary>
        [JsonProperty("phone")]
        public string Phone { get; set; }
    }
}