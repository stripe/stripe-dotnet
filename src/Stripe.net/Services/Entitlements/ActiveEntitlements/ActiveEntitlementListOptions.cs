// File generated from our OpenAPI spec
namespace Stripe.Entitlements
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class ActiveEntitlementListOptions : ListOptions
    {
        /// <summary>
        /// The ID of the customer.
        /// </summary>
        [JsonProperty("customer")]
        [STJS.JsonPropertyName("customer")]
        public string Customer { get; set; }
    }
}
