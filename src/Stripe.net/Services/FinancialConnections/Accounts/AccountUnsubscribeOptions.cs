// File generated from our OpenAPI spec
namespace Stripe.FinancialConnections
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountUnsubscribeOptions : BaseOptions
    {
        /// <summary>
        /// The list of account features from which you would like to unsubscribe.
        /// </summary>
        [JsonProperty("features")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("features")]
#endif
        public List<string> Features { get; set; }
    }
}
