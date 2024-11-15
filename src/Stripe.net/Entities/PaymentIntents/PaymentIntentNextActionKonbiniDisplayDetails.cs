// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentIntentNextActionKonbiniDisplayDetails : StripeEntity<PaymentIntentNextActionKonbiniDisplayDetails>
    {
        /// <summary>
        /// The timestamp at which the pending Konbini payment expires.
        /// </summary>
        [JsonProperty("expires_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("expires_at")]
#endif

        public DateTime ExpiresAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// The URL for the Konbini payment instructions page, which allows customers to view and
        /// print a Konbini voucher.
        /// </summary>
        [JsonProperty("hosted_voucher_url")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("hosted_voucher_url")]
#endif

        public string HostedVoucherUrl { get; set; }

        [JsonProperty("stores")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("stores")]
#endif

        public PaymentIntentNextActionKonbiniDisplayDetailsStores Stores { get; set; }
    }
}
