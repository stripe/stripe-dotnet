// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class PaymentIntentNextActionKonbiniDisplayDetails : StripeEntity<PaymentIntentNextActionKonbiniDisplayDetails>
    {
        /// <summary>
        /// The timestamp at which the pending Konbini payment expires.
        /// </summary>
        [JsonProperty("expires_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime ExpiresAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// The URL for the Konbini payment instructions page, which allows customers to view and
        /// print a Konbini voucher.
        /// </summary>
        [JsonProperty("hosted_voucher_url")]
        public string HostedVoucherUrl { get; set; }

        [JsonProperty("stores")]
        public PaymentIntentNextActionKonbiniDisplayDetailsStores Stores { get; set; }
    }
}
