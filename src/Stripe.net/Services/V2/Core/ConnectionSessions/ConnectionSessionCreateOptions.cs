// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class ConnectionSessionCreateOptions : BaseOptions
    {
        /// <summary>
        /// The Account the ConnectionSession will create a connection for.
        /// </summary>
        [JsonProperty("account")]
        [STJS.JsonPropertyName("account")]
        public string Account { get; set; }

        /// <summary>
        /// The Connection types that the ConnectionSession is allowed to establish.
        /// </summary>
        [JsonProperty("allowed_connection_types")]
        [STJS.JsonPropertyName("allowed_connection_types")]
        public List<string> AllowedConnectionTypes { get; set; }

        /// <summary>
        /// The access that should be collected with the ConnectionSession.
        /// </summary>
        [JsonProperty("requested_access")]
        [STJS.JsonPropertyName("requested_access")]
        public List<string> RequestedAccess { get; set; }
    }
}
