// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class CustomerTaxLocation : StripeEntity<CustomerTaxLocation>
    {
        /// <summary>
        /// The identified tax country of the customer.
        /// </summary>
        [JsonProperty("country")]
        [STJS.JsonPropertyName("country")]
        public string Country { get; set; }

        /// <summary>
        /// The data source used to infer the customer's location.
        /// One of: <c>billing_address</c>, <c>ip_address</c>, <c>payment_method</c>, or
        /// <c>shipping_destination</c>.
        /// </summary>
        [JsonProperty("source")]
        [STJS.JsonPropertyName("source")]
        public string Source { get; set; }

        /// <summary>
        /// The identified tax state, county, province, or region of the customer.
        /// </summary>
        [JsonProperty("state")]
        [STJS.JsonPropertyName("state")]
        public string State { get; set; }
    }
}
