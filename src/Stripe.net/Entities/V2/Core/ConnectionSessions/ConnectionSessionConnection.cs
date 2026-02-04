// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ConnectionSessionConnection : StripeEntity<ConnectionSessionConnection>
    {
        /// <summary>
        /// The access granted to the Account by the Connection.
        /// </summary>
        [JsonProperty("granted_access")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("granted_access")]
#endif
        public List<string> GrantedAccess { get; set; }

        /// <summary>
        /// The type of the Connection.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }
    }
}
