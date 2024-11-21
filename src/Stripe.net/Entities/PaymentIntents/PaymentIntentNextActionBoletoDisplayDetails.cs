// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentIntentNextActionBoletoDisplayDetails : StripeEntity<PaymentIntentNextActionBoletoDisplayDetails>
    {
        /// <summary>
        /// The timestamp after which the boleto expires.
        /// </summary>
        [JsonProperty("expires_at")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("expires_at")]
#endif

        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif

        public DateTime? ExpiresAt { get; set; }

        /// <summary>
        /// The URL to the hosted boleto voucher page, which allows customers to view the boleto
        /// voucher.
        /// </summary>
        [JsonProperty("hosted_voucher_url")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("hosted_voucher_url")]
#endif

        public string HostedVoucherUrl { get; set; }

        /// <summary>
        /// The boleto number.
        /// </summary>
        [JsonProperty("number")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("number")]
#endif

        public string Number { get; set; }

        /// <summary>
        /// The URL to the downloadable boleto voucher PDF.
        /// </summary>
        [JsonProperty("pdf")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("pdf")]
#endif

        public string Pdf { get; set; }
    }
}
