// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class RefundListOptions : ListOptions
    {
        /// <summary>
        /// Only return refunds for the charge specified by this charge ID.
        /// </summary>
        [JsonProperty("charge")]
        [STJS.JsonPropertyName("charge")]
        public string Charge { get; set; }

        /// <summary>
        /// Only return refunds that were created during the given date interval.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(AnyOfConverter))]
        [STJS.JsonPropertyName("created")]
        [STJS.JsonConverter(typeof(STJAnyOfConverter))]
        public AnyOf<DateTime?, DateRangeOptions> Created { get; set; }

        /// <summary>
        /// Only return refunds for the PaymentIntent specified by this ID.
        /// </summary>
        [JsonProperty("payment_intent")]
        [STJS.JsonPropertyName("payment_intent")]
        public string PaymentIntent { get; set; }
    }
}
