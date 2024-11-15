// File generated from our OpenAPI spec
namespace Stripe.Radar
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class EarlyFraudWarningListOptions : ListOptionsWithCreated
    {
        /// <summary>
        /// Only return early fraud warnings for the charge specified by this charge ID.
        /// </summary>
        [JsonProperty("charge")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("charge")]
#endif

        public string Charge { get; set; }

        /// <summary>
        /// Only return early fraud warnings for charges that were created by the PaymentIntent
        /// specified by this PaymentIntent ID.
        /// </summary>
        [JsonProperty("payment_intent")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payment_intent")]
#endif

        public string PaymentIntent { get; set; }
    }
}
