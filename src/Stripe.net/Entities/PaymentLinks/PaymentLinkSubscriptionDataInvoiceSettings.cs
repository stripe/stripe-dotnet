// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PaymentLinkSubscriptionDataInvoiceSettings : StripeEntity<PaymentLinkSubscriptionDataInvoiceSettings>
    {
        [JsonProperty("issuer")]
        [STJS.JsonPropertyName("issuer")]
        public PaymentLinkSubscriptionDataInvoiceSettingsIssuer Issuer { get; set; }
    }
}
