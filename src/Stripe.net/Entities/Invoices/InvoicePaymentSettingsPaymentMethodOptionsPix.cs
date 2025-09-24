// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class InvoicePaymentSettingsPaymentMethodOptionsPix : StripeEntity<InvoicePaymentSettingsPaymentMethodOptionsPix>
    {
        /// <summary>
        /// Determines if the amount includes the IOF tax.
        /// One of: <c>always</c>, or <c>never</c>.
        /// </summary>
        [JsonProperty("amount_includes_iof")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount_includes_iof")]
#endif
        public string AmountIncludesIof { get; set; }
    }
}
