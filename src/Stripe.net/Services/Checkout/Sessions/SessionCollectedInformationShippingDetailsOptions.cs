// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using Newtonsoft.Json;

    public class SessionCollectedInformationShippingDetailsOptions : INestedOptions
    {
        /// <summary>
        /// The address of the customer.
        /// </summary>
        [JsonProperty("address")]
        public AddressOptions Address { get; set; }

        /// <summary>
        /// The name of customer.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
