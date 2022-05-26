// File generated from our OpenAPI spec
namespace Stripe.FinancialConnections
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class SessionFiltersOptions : INestedOptions
    {
        /// <summary>
        /// List of countries from which to collect accounts.
        /// </summary>
        [JsonProperty("countries")]
        public List<string> Countries { get; set; }
    }
}
