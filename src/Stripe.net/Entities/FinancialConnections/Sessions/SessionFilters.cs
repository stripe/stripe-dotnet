// File generated from our OpenAPI spec
namespace Stripe.FinancialConnections
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class SessionFilters : StripeEntity<SessionFilters>
    {
        /// <summary>
        /// List of countries from which to filter accounts.
        /// </summary>
        [JsonProperty("countries")]
        public List<string> Countries { get; set; }
    }
}
