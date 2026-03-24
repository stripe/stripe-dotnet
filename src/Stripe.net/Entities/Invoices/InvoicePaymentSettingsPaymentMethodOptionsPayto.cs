// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class InvoicePaymentSettingsPaymentMethodOptionsPayto : StripeEntity<InvoicePaymentSettingsPaymentMethodOptionsPayto>
    {
        [JsonProperty("mandate_options")]
        [STJS.JsonPropertyName("mandate_options")]
        public InvoicePaymentSettingsPaymentMethodOptionsPaytoMandateOptions MandateOptions { get; set; }
    }
}
