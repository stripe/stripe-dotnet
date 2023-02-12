// File generated from our OpenAPI spec
namespace Stripe.Tax
{
    using Newtonsoft.Json;

    public class SettingsLocation : StripeEntity<SettingsLocation>
    {
        [JsonProperty("address")]
        public Address Address { get; set; }

        /// <summary>
        /// The role of this location address.
        /// </summary>
        [JsonProperty("role")]
        public string Role { get; set; }
    }
}
