// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    /// <summary>
    /// The ConnectionSession resource.
    /// </summary>
    public class ConnectionSession : StripeEntity<ConnectionSession>, IHasId, IHasObject
    {
        /// <summary>
        /// The unique identifier for this ConnectionSession.
        /// </summary>
        [JsonProperty("id")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("id")]
#endif
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value of
        /// the object field.
        /// </summary>
        [JsonProperty("object")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("object")]
#endif
        public string Object { get; set; }

        /// <summary>
        /// The Account this Connection Session was created for.
        /// </summary>
        [JsonProperty("account")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("account")]
#endif
        public string Account { get; set; }

        /// <summary>
        /// The Connection types that the Connection Session is allowed to establish.
        /// </summary>
        [JsonProperty("allowed_connection_types")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("allowed_connection_types")]
#endif
        public List<string> AllowedConnectionTypes { get; set; }

        /// <summary>
        /// The client secret of this Connection Session. Used on the client to set up secure access
        /// to the given Account.
        /// </summary>
        [JsonProperty("client_secret")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("client_secret")]
#endif
        public string ClientSecret { get; set; }

        /// <summary>
        /// The Connection created by the ConnectionSession.
        /// </summary>
        [JsonProperty("connection")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("connection")]
#endif
        public ConnectionSessionConnection Connection { get; set; }

        /// <summary>
        /// Time at which the ConnectionSession was created.
        /// </summary>
        [JsonProperty("created")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("created")]
#endif
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("livemode")]
#endif
        public bool Livemode { get; set; }

        /// <summary>
        /// The access that is collected with the Connection Session.
        /// </summary>
        [JsonProperty("requested_access")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("requested_access")]
#endif
        public List<string> RequestedAccess { get; set; }
    }
}
