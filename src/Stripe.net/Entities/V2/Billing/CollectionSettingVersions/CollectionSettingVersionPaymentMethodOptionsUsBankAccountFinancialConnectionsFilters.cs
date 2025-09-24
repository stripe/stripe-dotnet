// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class CollectionSettingVersionPaymentMethodOptionsUsBankAccountFinancialConnectionsFilters : StripeEntity<CollectionSettingVersionPaymentMethodOptionsUsBankAccountFinancialConnectionsFilters>
    {
        /// <summary>
        /// The account subcategories to use to filter for selectable accounts.
        /// One of: <c>checking</c>, or <c>savings</c>.
        /// </summary>
        [JsonProperty("account_subcategories")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("account_subcategories")]
#endif
        public List<string> AccountSubcategories { get; set; }
    }
}
