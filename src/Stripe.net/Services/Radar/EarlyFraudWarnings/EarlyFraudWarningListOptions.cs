// File generated from our OpenAPI spec
namespace Stripe.Radar
{
    using Newtonsoft.Json;

    public class EarlyFraudWarningListOptions : ListOptionsWithCreated
    {
        /// <summary>
        /// Only return early fraud warnings for the charge specified by this charge ID.
        /// </summary>
        [JsonProperty("charge")]
        public string Charge { get; set; }

        /// <summary>
        /// Only return early fraud warnings for charges that were created by the PaymentIntent
        /// specified by this PaymentIntent ID.
        /// </summary>
        [JsonProperty("payment_intent")]
        public string PaymentIntent { get; set; }
    }
}
