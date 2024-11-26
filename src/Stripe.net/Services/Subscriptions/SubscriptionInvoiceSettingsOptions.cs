// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class SubscriptionInvoiceSettingsOptions : INestedOptions
    {
        /// <summary>
        /// The account tax IDs associated with the subscription. Will be set on invoices generated
        /// by the subscription.
        /// </summary>
        [JsonProperty("account_tax_ids")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("account_tax_ids")]
#endif
        public List<string> AccountTaxIds { get; set; }

        /// <summary>
        /// The connected account that issues the invoice. The invoice is presented with the
        /// branding and support information of the specified account.
        /// </summary>
        [JsonProperty("issuer")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("issuer")]
#endif
        public SubscriptionInvoiceSettingsIssuerOptions Issuer { get; set; }
    }
}
