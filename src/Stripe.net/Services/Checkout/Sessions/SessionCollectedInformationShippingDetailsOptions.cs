// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class SessionCollectedInformationShippingDetailsOptions : INestedOptions
    {
        /// <summary>
        /// The address of the customer.
        /// </summary>
        [JsonProperty("address")]
        [STJS.JsonPropertyName("address")]
        public AddressOptions Address { get; set; }

        /// <summary>
        /// The name of customer.
        /// </summary>
        [JsonProperty("name")]
        [STJS.JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
