// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ConfirmationTokenPaymentMethodPreviewCardPresentOffline : StripeEntity<ConfirmationTokenPaymentMethodPreviewCardPresentOffline>
    {
        /// <summary>
        /// Time at which the payment was collected while offline.
        /// </summary>
        [JsonProperty("stored_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("stored_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif
        public DateTime? StoredAt { get; set; }

        /// <summary>
        /// The method used to process this payment method offline. Only deferred is allowed.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }
    }
}
