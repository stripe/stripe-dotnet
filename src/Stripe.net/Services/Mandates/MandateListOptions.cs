// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class MandateListOptions : ListOptions
    {
        /// <summary>
        /// The Stripe account ID that the mandates are intended for. Learn more about the <a
        /// href="https://docs.stripe.com/payments/connected-accounts">use case for connected
        /// accounts payments</a>.
        /// </summary>
        [JsonProperty("on_behalf_of")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("on_behalf_of")]
#endif
        public string OnBehalfOf { get; set; }

        [JsonProperty("payment_method")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payment_method")]
#endif
        public string PaymentMethod { get; set; }

        /// <summary>
        /// The status of the mandates to retrieve. Status indicates whether or not you can use it
        /// to initiate a payment, and can have a value of <c>active</c>, <c>pending</c>, or
        /// <c>inactive</c>.
        /// One of: <c>active</c>, <c>inactive</c>, or <c>pending</c>.
        /// </summary>
        [JsonProperty("status")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("status")]
#endif
        public string Status { get; set; }
    }
}
