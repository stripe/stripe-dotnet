// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentLinkSubscriptionDataInvoiceSettingsOptions : INestedOptions
    {
        /// <summary>
        /// The connected account that issues the invoice. The invoice is presented with the
        /// branding and support information of the specified account.
        /// </summary>
        [JsonProperty("issuer")]
        public PaymentLinkSubscriptionDataInvoiceSettingsIssuerOptions Issuer { get; set; }
    }
}
