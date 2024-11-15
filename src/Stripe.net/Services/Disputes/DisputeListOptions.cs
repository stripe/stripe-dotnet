// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class DisputeListOptions : ListOptionsWithCreated
    {
        /// <summary>
        /// Only return disputes associated to the charge specified by this charge ID.
        /// </summary>
        [JsonProperty("charge")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("charge")]
#endif

        public string Charge { get; set; }

        /// <summary>
        /// Only return disputes associated to the PaymentIntent specified by this PaymentIntent ID.
        /// </summary>
        [JsonProperty("payment_intent")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payment_intent")]
#endif

        public string PaymentIntent { get; set; }
    }
}
