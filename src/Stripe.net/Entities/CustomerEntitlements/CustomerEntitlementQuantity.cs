// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class CustomerEntitlementQuantity : StripeEntity<CustomerEntitlementQuantity>
    {
        /// <summary>
        /// The total quantity available to the customer.
        /// </summary>
        [JsonProperty("total_available")]
        public long TotalAvailable { get; set; }
    }
}
