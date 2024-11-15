// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class SessionListOptions : ListOptionsWithCreated
    {
        /// <summary>
        /// Only return the Checkout Sessions for the Customer specified.
        /// </summary>
        [JsonProperty("customer")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("customer")]
#endif

        public string Customer { get; set; }

        /// <summary>
        /// Only return the Checkout Sessions for the Customer details specified.
        /// </summary>
        [JsonProperty("customer_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("customer_details")]
#endif

        public SessionCustomerDetailsOptions CustomerDetails { get; set; }

        /// <summary>
        /// Only return the Checkout Session for the PaymentIntent specified.
        /// </summary>
        [JsonProperty("payment_intent")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payment_intent")]
#endif

        public string PaymentIntent { get; set; }

        /// <summary>
        /// Only return the Checkout Sessions for the Payment Link specified.
        /// </summary>
        [JsonProperty("payment_link")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payment_link")]
#endif

        public string PaymentLink { get; set; }

        /// <summary>
        /// Only return the Checkout Sessions matching the given status.
        /// One of: <c>complete</c>, <c>expired</c>, or <c>open</c>.
        /// </summary>
        [JsonProperty("status")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("status")]
#endif

        public string Status { get; set; }

        /// <summary>
        /// Only return the Checkout Session for the subscription specified.
        /// </summary>
        [JsonProperty("subscription")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("subscription")]
#endif

        public string Subscription { get; set; }
    }
}
