// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class InvoiceShippingDetailsOptions : INestedOptions
    {
        /// <summary>
        /// Shipping address.
        /// </summary>
        [JsonProperty("address")]
        public AddressOptions Address { get; set; }

        /// <summary>
        /// Recipient name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Recipient phone (including extension).
        /// </summary>
        [JsonProperty("phone")]
        public string Phone { get; set; }
    }
}
