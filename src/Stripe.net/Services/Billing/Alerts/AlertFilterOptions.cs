// File generated from our OpenAPI spec
namespace Stripe.Billing
{
    using Newtonsoft.Json;

    public class AlertFilterOptions : INestedOptions
    {
        /// <summary>
        /// Limit the scope to this alert only to this customer.
        /// </summary>
        [JsonProperty("customer")]
        public string Customer { get; set; }
    }
}
