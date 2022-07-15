// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class OrderBillingDetailsOptions : INestedOptions
    {
        /// <summary>
        /// The billing address provided by the customer.
        /// </summary>
        [JsonProperty("address")]
        public AddressOptions Address { get; set; }

        /// <summary>
        /// The billing email provided by the customer.
        /// </summary>
        [JsonProperty("email")]
        public string Email { get; set; }

        /// <summary>
        /// The billing name provided by the customer.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// The billing phone number provided by the customer.
        /// </summary>
        [JsonProperty("phone")]
        public string Phone { get; set; }
    }
}
