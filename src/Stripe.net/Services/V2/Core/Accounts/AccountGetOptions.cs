// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountGetOptions : BaseOptions
    {
        /// <summary>
        /// Additional fields to include in the response.
        /// One of: <c>configuration.customer</c>, <c>configuration.merchant</c>,
        /// <c>configuration.recipient</c>, <c>defaults</c>, <c>identity</c>, or
        /// <c>requirements</c>.
        /// </summary>
        [JsonProperty("include")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("include")]
#endif
        public List<string> Include { get; set; }
    }
}
