// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class QuotePreviewInvoicePaymentSettingsPaymentMethodOptionsCheckScan : StripeEntity<QuotePreviewInvoicePaymentSettingsPaymentMethodOptionsCheckScan>
    {
        [JsonProperty("check_deposit_address")]
        [STJS.JsonPropertyName("check_deposit_address")]
        public QuotePreviewInvoicePaymentSettingsPaymentMethodOptionsCheckScanCheckDepositAddress CheckDepositAddress { get; set; }
    }
}
