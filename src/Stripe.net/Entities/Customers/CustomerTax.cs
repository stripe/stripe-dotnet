// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class CustomerTax : StripeEntity<CustomerTax>
    {
        /// <summary>
        /// Surfaces if automatic tax computation is possible given the current customer location
        /// information.
        /// One of: <c>failed</c>, <c>not_collecting</c>, <c>supported</c>, or
        /// <c>unrecognized_location</c>.
        /// </summary>
        [JsonProperty("automatic_tax")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("automatic_tax")]
#endif
        public string AutomaticTax { get; set; }

        /// <summary>
        /// A recent IP address of the customer used for tax reporting and tax location inference.
        /// </summary>
        [JsonProperty("ip_address")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("ip_address")]
#endif
        public string IpAddress { get; set; }

        /// <summary>
        /// The identified tax location of the customer.
        /// </summary>
        [JsonProperty("location")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("location")]
#endif
        public CustomerTaxLocation Location { get; set; }
    }
}
