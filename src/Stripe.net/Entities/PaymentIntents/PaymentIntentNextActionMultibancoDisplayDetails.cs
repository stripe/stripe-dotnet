// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class PaymentIntentNextActionMultibancoDisplayDetails : StripeEntity<PaymentIntentNextActionMultibancoDisplayDetails>
    {
        /// <summary>
        /// Entity number associated with this Multibanco payment.
        /// </summary>
        [JsonProperty("entity")]
        public string Entity { get; set; }

        /// <summary>
        /// The timestamp at which the Multibanco voucher expires.
        /// </summary>
        [JsonProperty("expires_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? ExpiresAt { get; set; }

        /// <summary>
        /// The URL for the hosted Multibanco voucher page, which allows customers to view a
        /// Multibanco voucher.
        /// </summary>
        [JsonProperty("hosted_voucher_url")]
        public string HostedVoucherUrl { get; set; }

        /// <summary>
        /// Reference number associated with this Multibanco payment.
        /// </summary>
        [JsonProperty("reference")]
        public string Reference { get; set; }
    }
}
