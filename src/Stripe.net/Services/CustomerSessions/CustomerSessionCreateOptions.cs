// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class CustomerSessionCreateOptions : BaseOptions
    {
        /// <summary>
        /// Configuration for each component. Exactly 1 component must be enabled.
        /// </summary>
        [JsonProperty("components")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("components")]
#endif
        public CustomerSessionComponentsOptions Components { get; set; }

        /// <summary>
        /// The ID of an existing customer for which to create the Customer Session.
        /// </summary>
        [JsonProperty("customer")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("customer")]
#endif
        public string Customer { get; set; }

        /// <summary>
        /// The ID of an existing Account for which to create the Customer Session.
        /// </summary>
        [JsonProperty("customer_account")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("customer_account")]
#endif
        public string CustomerAccount { get; set; }
    }
}
