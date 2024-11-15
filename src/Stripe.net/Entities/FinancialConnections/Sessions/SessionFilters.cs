// File generated from our OpenAPI spec
namespace Stripe.FinancialConnections
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class SessionFilters : StripeEntity<SessionFilters>
    {
        /// <summary>
        /// Restricts the Session to subcategories of accounts that can be linked. Valid
        /// subcategories are: <c>checking</c>, <c>savings</c>, <c>mortgage</c>,
        /// <c>line_of_credit</c>, <c>credit_card</c>.
        /// One of: <c>checking</c>, <c>credit_card</c>, <c>line_of_credit</c>, <c>mortgage</c>, or
        /// <c>savings</c>.
        /// </summary>
        [JsonProperty("account_subcategories")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("account_subcategories")]
#endif

        public List<string> AccountSubcategories { get; set; }

        /// <summary>
        /// List of countries from which to filter accounts.
        /// </summary>
        [JsonProperty("countries")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("countries")]
#endif

        public List<string> Countries { get; set; }
    }
}
