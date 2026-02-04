// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ConnectionSessionCreateOptions : BaseOptions
    {
        /// <summary>
        /// The Account the ConnectionSession will create a connection for.
        /// </summary>
        [JsonProperty("account")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("account")]
#endif
        public string Account { get; set; }

        /// <summary>
        /// The Connection types that the ConnectionSession is allowed to establish.
        /// </summary>
        [JsonProperty("allowed_connection_types")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("allowed_connection_types")]
#endif
        public List<string> AllowedConnectionTypes { get; set; }

        /// <summary>
        /// The access that should be collected with the ConnectionSession.
        /// </summary>
        [JsonProperty("requested_access")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("requested_access")]
#endif
        public List<string> RequestedAccess { get; set; }
    }
}
