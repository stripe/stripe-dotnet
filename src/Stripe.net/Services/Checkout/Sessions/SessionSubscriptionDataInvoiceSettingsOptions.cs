// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using Newtonsoft.Json;

    public class SessionSubscriptionDataInvoiceSettingsOptions : INestedOptions
    {
        /// <summary>
        /// The connected account that issues the invoice. The invoice is presented with the
        /// branding and support information of the specified account.
        /// </summary>
        [JsonProperty("issuer")]
        public SessionSubscriptionDataInvoiceSettingsIssuerOptions Issuer { get; set; }
    }
}
