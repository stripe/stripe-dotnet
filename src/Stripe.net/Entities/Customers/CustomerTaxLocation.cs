// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class CustomerTaxLocation : StripeEntity<CustomerTaxLocation>
    {
        /// <summary>
        /// The identified tax country of the customer.
        /// </summary>
        [JsonProperty("country")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("country")]
#endif
        public string Country { get; set; }

        /// <summary>
        /// The data source used to infer the customer's location.
        /// One of: <c>billing_address</c>, <c>ip_address</c>, <c>payment_method</c>, or
        /// <c>shipping_destination</c>.
        /// </summary>
        [JsonProperty("source")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("source")]
#endif
        public string Source { get; set; }

        /// <summary>
        /// The identified tax state, county, province, or region of the customer.
        /// </summary>
        [JsonProperty("state")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("state")]
#endif
        public string State { get; set; }
    }
}
