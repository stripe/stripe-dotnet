// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PaymentIntentNextActionBoletoDisplayDetails : StripeEntity<PaymentIntentNextActionBoletoDisplayDetails>
    {
        /// <summary>
        /// The timestamp after which the boleto expires.
        /// </summary>
        [JsonProperty("expires_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("expires_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime? ExpiresAt { get; set; }

        /// <summary>
        /// The URL to the hosted boleto voucher page, which allows customers to view the boleto
        /// voucher.
        /// </summary>
        [JsonProperty("hosted_voucher_url")]
        [STJS.JsonPropertyName("hosted_voucher_url")]
        public string HostedVoucherUrl { get; set; }

        /// <summary>
        /// The boleto number.
        /// </summary>
        [JsonProperty("number")]
        [STJS.JsonPropertyName("number")]
        public string Number { get; set; }

        /// <summary>
        /// The URL to the downloadable boleto voucher PDF.
        /// </summary>
        [JsonProperty("pdf")]
        [STJS.JsonPropertyName("pdf")]
        public string Pdf { get; set; }
    }
}
