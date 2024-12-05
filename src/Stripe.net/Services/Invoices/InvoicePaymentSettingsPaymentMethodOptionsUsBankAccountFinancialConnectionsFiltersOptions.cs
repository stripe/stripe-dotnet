// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class InvoicePaymentSettingsPaymentMethodOptionsUsBankAccountFinancialConnectionsFiltersOptions : INestedOptions
    {
        /// <summary>
        /// The account subcategories to use to filter for selectable accounts. Valid subcategories
        /// are <c>checking</c> and <c>savings</c>.
        /// One of: <c>checking</c>, or <c>savings</c>.
        /// </summary>
        [JsonProperty("account_subcategories")]
        public List<string> AccountSubcategories { get; set; }
    }
}
