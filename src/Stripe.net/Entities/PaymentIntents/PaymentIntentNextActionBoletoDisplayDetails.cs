// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class PaymentIntentNextActionBoletoDisplayDetails : StripeEntity<PaymentIntentNextActionBoletoDisplayDetails>
    {
        /// <summary>
        /// The timestamp after which the boleto expires.
        /// </summary>
        [JsonProperty("expires_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? ExpiresAt { get; set; }

        /// <summary>
        /// The URL to the hosted boleto voucher page, which allows customers to view the boleto
        /// voucher.
        /// </summary>
        [JsonProperty("hosted_voucher_url")]
        public string HostedVoucherUrl { get; set; }

        /// <summary>
        /// The boleto number.
        /// </summary>
        [JsonProperty("number")]
        public string Number { get; set; }

        /// <summary>
        /// The URL to the downloadable boleto voucher PDF.
        /// </summary>
        [JsonProperty("pdf")]
        public string Pdf { get; set; }
    }
}
