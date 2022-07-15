// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class OrderShippingDetailsOptions : INestedOptions
    {
        /// <summary>
        /// The shipping address for the order.
        /// </summary>
        [JsonProperty("address")]
        public AddressOptions Address { get; set; }

        /// <summary>
        /// The name of the recipient of the order.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// The phone number (including extension) for the recipient of the order.
        /// </summary>
        [JsonProperty("phone")]
        public string Phone { get; set; }
    }
}
