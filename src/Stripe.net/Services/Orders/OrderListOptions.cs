// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class OrderListOptions : ListOptions
    {
        /// <summary>
        /// Only return orders for the given customer.
        /// </summary>
        [JsonProperty("customer")]
        public string Customer { get; set; }
    }
}
