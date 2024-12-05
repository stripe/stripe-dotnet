// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentLinkSubscriptionDataInvoiceSettings : StripeEntity<PaymentLinkSubscriptionDataInvoiceSettings>
    {
        [JsonProperty("issuer")]
        public PaymentLinkSubscriptionDataInvoiceSettingsIssuer Issuer { get; set; }
    }
}
