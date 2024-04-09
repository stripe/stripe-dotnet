// File generated from our OpenAPI spec
namespace Stripe.Entitlements
{
    using Newtonsoft.Json;

    public class ActiveEntitlementListOptions : ListOptions
    {
        /// <summary>
        /// The ID of the customer.
        /// </summary>
        [JsonProperty("customer")]
        public string Customer { get; set; }
    }
}
