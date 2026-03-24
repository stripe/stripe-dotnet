// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ConnectionSessionConnection : StripeEntity<ConnectionSessionConnection>
    {
        /// <summary>
        /// The access granted to the Account by the Connection.
        /// </summary>
        [JsonProperty("granted_access")]
        [STJS.JsonPropertyName("granted_access")]
        public List<string> GrantedAccess { get; set; }

        /// <summary>
        /// The type of the Connection.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
