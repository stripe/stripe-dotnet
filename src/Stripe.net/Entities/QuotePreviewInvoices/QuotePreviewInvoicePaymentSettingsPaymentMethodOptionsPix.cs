// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class QuotePreviewInvoicePaymentSettingsPaymentMethodOptionsPix : StripeEntity<QuotePreviewInvoicePaymentSettingsPaymentMethodOptionsPix>
    {
        /// <summary>
        /// Determines if the amount includes the IOF tax.
        /// One of: <c>always</c>, or <c>never</c>.
        /// </summary>
        [JsonProperty("amount_includes_iof")]
        [STJS.JsonPropertyName("amount_includes_iof")]
        public string AmountIncludesIof { get; set; }

        /// <summary>
        /// The number of seconds (between 10 and 1209600) after which Pix payment will expire.
        /// Defaults to 86400 seconds.
        /// </summary>
        [JsonProperty("expires_after_seconds")]
        [STJS.JsonPropertyName("expires_after_seconds")]
        public long ExpiresAfterSeconds { get; set; }
    }
}
