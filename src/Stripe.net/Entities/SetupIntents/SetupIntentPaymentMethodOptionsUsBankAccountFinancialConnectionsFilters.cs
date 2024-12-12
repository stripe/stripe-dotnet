// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class SetupIntentPaymentMethodOptionsUsBankAccountFinancialConnectionsFilters : StripeEntity<SetupIntentPaymentMethodOptionsUsBankAccountFinancialConnectionsFilters>
    {
        /// <summary>
        /// The account subcategories to use to filter for possible accounts to link. Valid
        /// subcategories are <c>checking</c> and <c>savings</c>.
        /// One of: <c>checking</c>, or <c>savings</c>.
        /// </summary>
        [JsonProperty("account_subcategories")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("account_subcategories")]
#endif
        public List<string> AccountSubcategories { get; set; }

        /// <summary>
        /// The institution to use to filter for possible accounts to link.
        /// </summary>
        [JsonProperty("institution")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("institution")]
#endif
        public string Institution { get; set; }
    }
}
