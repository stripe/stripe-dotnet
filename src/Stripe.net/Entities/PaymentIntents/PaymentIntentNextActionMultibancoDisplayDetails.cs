// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentIntentNextActionMultibancoDisplayDetails : StripeEntity<PaymentIntentNextActionMultibancoDisplayDetails>
    {
        /// <summary>
        /// Entity number associated with this Multibanco payment.
        /// </summary>
        [JsonProperty("entity")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("entity")]
#endif

        public string Entity { get; set; }

        /// <summary>
        /// The timestamp at which the Multibanco voucher expires.
        /// </summary>
        [JsonProperty("expires_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("expires_at")]
#endif

        public DateTime? ExpiresAt { get; set; }

        /// <summary>
        /// The URL for the hosted Multibanco voucher page, which allows customers to view a
        /// Multibanco voucher.
        /// </summary>
        [JsonProperty("hosted_voucher_url")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("hosted_voucher_url")]
#endif

        public string HostedVoucherUrl { get; set; }

        /// <summary>
        /// Reference number associated with this Multibanco payment.
        /// </summary>
        [JsonProperty("reference")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("reference")]
#endif

        public string Reference { get; set; }
    }
}
