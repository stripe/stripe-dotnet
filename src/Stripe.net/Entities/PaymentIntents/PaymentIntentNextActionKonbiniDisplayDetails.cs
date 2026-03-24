// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PaymentIntentNextActionKonbiniDisplayDetails : StripeEntity<PaymentIntentNextActionKonbiniDisplayDetails>
    {
        /// <summary>
        /// The timestamp at which the pending Konbini payment expires.
        /// </summary>
        [JsonProperty("expires_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("expires_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime ExpiresAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// The URL for the Konbini payment instructions page, which allows customers to view and
        /// print a Konbini voucher.
        /// </summary>
        [JsonProperty("hosted_voucher_url")]
        [STJS.JsonPropertyName("hosted_voucher_url")]
        public string HostedVoucherUrl { get; set; }

        [JsonProperty("stores")]
        [STJS.JsonPropertyName("stores")]
        public PaymentIntentNextActionKonbiniDisplayDetailsStores Stores { get; set; }
    }
}
