// File generated from our OpenAPI spec
namespace Stripe.V2.Core.Vault
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class UsBankAccountUpdateOptions : BaseOptions
    {
        /// <summary>
        /// The bank account's Fedwire routing number can be provided for update if it was empty
        /// previously.
        /// </summary>
        [JsonProperty("fedwire_routing_number")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("fedwire_routing_number")]
#endif
        public string FedwireRoutingNumber { get; set; }

        /// <summary>
        /// The bank account's ACH routing number can be provided for update if it was empty
        /// previously.
        /// </summary>
        [JsonProperty("routing_number")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("routing_number")]
#endif
        public string RoutingNumber { get; set; }
    }
}
