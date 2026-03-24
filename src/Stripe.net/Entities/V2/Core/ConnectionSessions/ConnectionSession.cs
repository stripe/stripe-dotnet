// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    /// <summary>
    /// The ConnectionSession resource.
    /// </summary>
    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ConnectionSession : StripeEntity<ConnectionSession>, IHasId, IHasObject
    {
        /// <summary>
        /// The unique identifier for this ConnectionSession.
        /// </summary>
        [JsonProperty("id")]
        [STJS.JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value of
        /// the object field.
        /// </summary>
        [JsonProperty("object")]
        [STJS.JsonPropertyName("object")]
        public string Object { get; set; }

        /// <summary>
        /// The Account this Connection Session was created for.
        /// </summary>
        [JsonProperty("account")]
        [STJS.JsonPropertyName("account")]
        public string Account { get; set; }

        /// <summary>
        /// The Connection types that the Connection Session is allowed to establish.
        /// </summary>
        [JsonProperty("allowed_connection_types")]
        [STJS.JsonPropertyName("allowed_connection_types")]
        public List<string> AllowedConnectionTypes { get; set; }

        /// <summary>
        /// The client secret of this Connection Session. Used on the client to set up secure access
        /// to the given Account.
        /// </summary>
        [JsonProperty("client_secret")]
        [STJS.JsonPropertyName("client_secret")]
        public string ClientSecret { get; set; }

        /// <summary>
        /// The Connection created by the ConnectionSession.
        /// </summary>
        [JsonProperty("connection")]
        [STJS.JsonPropertyName("connection")]
        public ConnectionSessionConnection Connection { get; set; }

        /// <summary>
        /// Time at which the ConnectionSession was created.
        /// </summary>
        [JsonProperty("created")]
        [STJS.JsonPropertyName("created")]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
        [STJS.JsonPropertyName("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// The access that is collected with the Connection Session.
        /// </summary>
        [JsonProperty("requested_access")]
        [STJS.JsonPropertyName("requested_access")]
        public List<string> RequestedAccess { get; set; }
    }
}
