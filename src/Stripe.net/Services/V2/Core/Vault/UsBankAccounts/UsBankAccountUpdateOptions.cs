// File generated from our OpenAPI spec
namespace Stripe.V2.Core.Vault
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class UsBankAccountUpdateOptions : BaseOptions
    {
        /// <summary>
        /// The bank account's Fedwire routing number can be provided for update if it was empty
        /// previously.
        /// </summary>
        [JsonProperty("fedwire_routing_number")]
        [STJS.JsonPropertyName("fedwire_routing_number")]
        public string FedwireRoutingNumber { get; set; }

        /// <summary>
        /// The bank account's ACH routing number can be provided for update if it was empty
        /// previously.
        /// </summary>
        [JsonProperty("routing_number")]
        [STJS.JsonPropertyName("routing_number")]
        public string RoutingNumber { get; set; }
    }
}
