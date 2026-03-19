// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PaymentAttemptRecordPaymentMethodDetailsCardPresentOffline : StripeEntity<PaymentAttemptRecordPaymentMethodDetailsCardPresentOffline>
    {
        /// <summary>
        /// Time at which the payment was collected while offline.
        /// </summary>
        [JsonProperty("stored_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("stored_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime? StoredAt { get; set; }

        /// <summary>
        /// The method used to process this payment method offline. Only deferred is allowed.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
