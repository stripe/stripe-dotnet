// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountListOptions : V2.ListOptions
    {
        /// <summary>
        /// Filter only accounts that have all of the configurations specified. If omitted, returns
        /// all accounts regardless of which configurations they have.
        /// One of: <c>customer</c>, <c>merchant</c>, or <c>recipient</c>.
        /// </summary>
        [JsonProperty("applied_configurations")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("applied_configurations")]
#endif
        public List<string> AppliedConfigurations { get; set; }

        /// <summary>
        /// Filter by whether the account is closed. If omitted, returns only Accounts that are not
        /// closed.
        /// </summary>
        [JsonProperty("closed")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("closed")]
#endif
        public bool? Closed { get; set; }
    }
}
