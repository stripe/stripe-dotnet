// File generated from our OpenAPI spec
namespace Stripe.FinancialConnections
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

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
        public List<string> AccountSubcategories { get; set; }

        /// <summary>
        /// List of countries from which to filter accounts.
        /// </summary>
        [JsonProperty("countries")]
        public List<string> Countries { get; set; }

        /// <summary>
        /// Stripe ID of the institution with which the customer should be directed to log in.
        /// </summary>
        [JsonProperty("institution")]
        public string Institution { get; set; }
    }
}
