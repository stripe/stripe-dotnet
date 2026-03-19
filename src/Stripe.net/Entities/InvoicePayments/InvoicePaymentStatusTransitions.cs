// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class InvoicePaymentStatusTransitions : StripeEntity<InvoicePaymentStatusTransitions>
    {
        /// <summary>
        /// The time that the payment was canceled.
        /// </summary>
        [JsonProperty("canceled_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("canceled_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime? CanceledAt { get; set; }

        /// <summary>
        /// The time that the payment succeeded.
        /// </summary>
        [JsonProperty("paid_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("paid_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime? PaidAt { get; set; }
    }
}
