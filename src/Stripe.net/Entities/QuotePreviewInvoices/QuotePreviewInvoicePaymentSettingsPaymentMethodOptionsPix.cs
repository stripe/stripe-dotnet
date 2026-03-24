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
    }
}
