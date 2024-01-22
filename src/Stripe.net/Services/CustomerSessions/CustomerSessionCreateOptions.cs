// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class CustomerSessionCreateOptions : BaseOptions
    {
        /// <summary>
        /// Configuration for each component. Exactly 1 component must be enabled.
        /// </summary>
        [JsonProperty("components")]
        public CustomerSessionComponentsOptions Components { get; set; }

        /// <summary>
        /// The ID of an existing customer for which to create the customer session.
        /// </summary>
        [JsonProperty("customer")]
        public string Customer { get; set; }
    }
}
