// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class CustomerSessionCreateOptions : BaseOptions
    {
        /// <summary>
        /// Configuration for each component. At least 1 component must be enabled.
        /// </summary>
        [JsonProperty("components")]
        [STJS.JsonPropertyName("components")]
        public CustomerSessionComponentsOptions Components { get; set; }

        /// <summary>
        /// The ID of an existing customer for which to create the Customer Session.
        /// </summary>
        [JsonProperty("customer")]
        [STJS.JsonPropertyName("customer")]
        public string Customer { get; set; }

        /// <summary>
        /// The ID of an existing Account for which to create the Customer Session.
        /// </summary>
        [JsonProperty("customer_account")]
        [STJS.JsonPropertyName("customer_account")]
        public string CustomerAccount { get; set; }
    }
}
