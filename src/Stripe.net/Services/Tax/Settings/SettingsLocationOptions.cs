// File generated from our OpenAPI spec
namespace Stripe.Tax
{
    using Newtonsoft.Json;

    public class SettingsLocationOptions : INestedOptions
    {
        /// <summary>
        /// The location of the business for tax purposes.
        /// </summary>
        [JsonProperty("address")]
        public AddressOptions Address { get; set; }

        /// <summary>
        /// The role of this location address.
        /// </summary>
        [JsonProperty("role")]
        public string Role { get; set; }
    }
}
