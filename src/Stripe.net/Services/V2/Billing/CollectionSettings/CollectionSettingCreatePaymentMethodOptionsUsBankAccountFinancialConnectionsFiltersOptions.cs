// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class CollectionSettingCreatePaymentMethodOptionsUsBankAccountFinancialConnectionsFiltersOptions : INestedOptions
    {
        /// <summary>
        /// The account subcategories to use to filter for selectable accounts.
        /// One of: <c>checking</c>, or <c>savings</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("account_subcategories")]
        [STJS.JsonPropertyName("account_subcategories")]
        public List<string> AccountSubcategories { get; set; }
    }
}
