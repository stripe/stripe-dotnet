// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class InvoicePaymentSettingsPaymentMethodOptionsCheckScan : StripeEntity<InvoicePaymentSettingsPaymentMethodOptionsCheckScan>
    {
        [JsonProperty("check_deposit_address")]
        [STJS.JsonPropertyName("check_deposit_address")]
        public InvoicePaymentSettingsPaymentMethodOptionsCheckScanCheckDepositAddress CheckDepositAddress { get; set; }
    }
}
