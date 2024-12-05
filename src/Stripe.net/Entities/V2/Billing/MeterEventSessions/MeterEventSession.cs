// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using System;
    using Newtonsoft.Json;

    public class MeterEventSession : StripeEntity<MeterEventSession>, IHasId, IHasObject
    {
        /// <summary>
        /// The unique id of this auth session.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value of
        /// the object field.
        /// </summary>
        [JsonProperty("object")]
        public string Object { get; set; }

        /// <summary>
        /// The authentication token for this session.  Use this token when calling the
        /// high-throughput meter event API.
        /// </summary>
        [JsonProperty("authentication_token")]
        public string AuthenticationToken { get; set; }

        /// <summary>
        /// The creation time of this session.
        /// </summary>
        [JsonProperty("created")]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// The time at which this session will expire.
        /// </summary>
        [JsonProperty("expires_at")]
        public DateTime ExpiresAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
        public bool Livemode { get; set; }
    }
}
