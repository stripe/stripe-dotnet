// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentLinkSubscriptionDataInvoiceSettings : StripeEntity<PaymentLinkSubscriptionDataInvoiceSettings>
    {
        [JsonProperty("issuer")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("issuer")]
#endif
        public PaymentLinkSubscriptionDataInvoiceSettingsIssuer Issuer { get; set; }
    }
}
