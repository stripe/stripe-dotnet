// File generated from our OpenAPI spec
namespace Stripe.FinancialConnections
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountRefreshOptions : BaseOptions
    {
        /// <summary>
        /// The list of account features that you would like to refresh.
        /// One of: <c>balance</c>, <c>ownership</c>, or <c>transactions</c>.
        /// </summary>
        [JsonProperty("features")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("features")]
#endif

        public List<string> Features { get; set; }
    }
}
