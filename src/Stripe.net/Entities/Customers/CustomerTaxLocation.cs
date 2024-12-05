// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class CustomerTaxLocation : StripeEntity<CustomerTaxLocation>
    {
        /// <summary>
        /// The customer's country as identified by Stripe Tax.
        /// </summary>
        [JsonProperty("country")]
        public string Country { get; set; }

        /// <summary>
        /// The data source used to infer the customer's location.
        /// One of: <c>billing_address</c>, <c>ip_address</c>, <c>payment_method</c>, or
        /// <c>shipping_destination</c>.
        /// </summary>
        [JsonProperty("source")]
        public string Source { get; set; }

        /// <summary>
        /// The customer's state, county, province, or region as identified by Stripe Tax.
        /// </summary>
        [JsonProperty("state")]
        public string State { get; set; }
    }
}
