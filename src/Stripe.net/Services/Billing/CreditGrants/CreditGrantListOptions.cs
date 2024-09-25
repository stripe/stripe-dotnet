// File generated from our OpenAPI spec
namespace Stripe.Billing
{
    using Newtonsoft.Json;

    public class CreditGrantListOptions : ListOptions
    {
        /// <summary>
        /// Only return credit grants for this customer.
        /// </summary>
        [JsonProperty("customer")]
        public string Customer { get; set; }
    }
}
