// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountSettingsInvoicesOptions : INestedOptions
    {
        /// <summary>
        /// The list of default Account Tax IDs to automatically include on invoices. Account Tax
        /// IDs get added when an invoice is finalized.
        /// </summary>
        [JsonProperty("default_account_tax_ids")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("default_account_tax_ids")]
#endif

        public List<string> DefaultAccountTaxIds { get; set; }
    }
}
