// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PaymentIntentNextActionOxxoDisplayDetails : StripeEntity<PaymentIntentNextActionOxxoDisplayDetails>
    {
        /// <summary>
        /// The timestamp after which the OXXO voucher expires.
        /// </summary>
        [JsonProperty("expires_after")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("expires_after")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime? ExpiresAfter { get; set; }

        /// <summary>
        /// The URL for the hosted OXXO voucher page, which allows customers to view and print an
        /// OXXO voucher.
        /// </summary>
        [JsonProperty("hosted_voucher_url")]
        [STJS.JsonPropertyName("hosted_voucher_url")]
        public string HostedVoucherUrl { get; set; }

        /// <summary>
        /// OXXO reference number.
        /// </summary>
        [JsonProperty("number")]
        [STJS.JsonPropertyName("number")]
        public string Number { get; set; }
    }
}
