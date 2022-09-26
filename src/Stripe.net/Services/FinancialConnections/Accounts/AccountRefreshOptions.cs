// File generated from our OpenAPI spec
namespace Stripe.FinancialConnections
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class AccountRefreshOptions : BaseOptions
    {
        /// <summary>
        /// The list of account features that you would like to refresh.
        /// </summary>
        [JsonProperty("features")]
        public List<string> Features { get; set; }
    }
}
