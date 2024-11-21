// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentIntentNextActionOxxoDisplayDetails : StripeEntity<PaymentIntentNextActionOxxoDisplayDetails>
    {
        /// <summary>
        /// The timestamp after which the OXXO voucher expires.
        /// </summary>
        [JsonProperty("expires_after")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("expires_after")]
#endif

        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif

        public DateTime? ExpiresAfter { get; set; }

        /// <summary>
        /// The URL for the hosted OXXO voucher page, which allows customers to view and print an
        /// OXXO voucher.
        /// </summary>
        [JsonProperty("hosted_voucher_url")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("hosted_voucher_url")]
#endif

        public string HostedVoucherUrl { get; set; }

        /// <summary>
        /// OXXO reference number.
        /// </summary>
        [JsonProperty("number")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("number")]
#endif

        public string Number { get; set; }
    }
}
