// File generated from our OpenAPI spec
namespace Stripe.V2
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountListOptions : ListOptions
    {
        /// <summary>
        /// Filter by the configurations that have been applied to the account. If omitted, returns
        /// all Accounts regardless of which configurations they have. Currently only supports
        /// <c>recipient</c>, to filter by Accounts with the recipient configuration set.
        /// </summary>
        [JsonProperty("applied_configurations")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("applied_configurations")]
#endif
        public List<string> AppliedConfigurations { get; set; }
    }
}
