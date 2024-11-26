// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class RefundListOptions : ListOptionsWithCreated
    {
        /// <summary>
        /// Only return refunds for the charge specified by this charge ID.
        /// </summary>
        [JsonProperty("charge")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("charge")]
#endif
        public string Charge { get; set; }

        /// <summary>
        /// Only return refunds for the PaymentIntent specified by this ID.
        /// </summary>
        [JsonProperty("payment_intent")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payment_intent")]
#endif
        public string PaymentIntent { get; set; }
    }
}
