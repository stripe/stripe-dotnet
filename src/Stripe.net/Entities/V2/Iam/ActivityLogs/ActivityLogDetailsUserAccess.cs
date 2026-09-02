// File generated from our OpenAPI spec
namespace Stripe.V2.Iam
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ActivityLogDetailsUserAccess : StripeEntity<ActivityLogDetailsUserAccess>
    {
        /// <summary>
        /// Authentication details for the user access action.
        /// </summary>
        [JsonProperty("authentication")]
        [STJS.JsonPropertyName("authentication")]
        public ActivityLogDetailsUserAccessAuthentication Authentication { get; set; }

        /// <summary>
        /// Dashboard client details for the user access action.
        /// </summary>
        [JsonProperty("dashboard_client")]
        [STJS.JsonPropertyName("dashboard_client")]
        public ActivityLogDetailsUserAccessDashboardClient DashboardClient { get; set; }

        /// <summary>
        /// Timestamp when the user access expires.
        /// </summary>
        [JsonProperty("expires_at")]
        [STJS.JsonPropertyName("expires_at")]
        public DateTime ExpiresAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Network details for the user access action.
        /// </summary>
        [JsonProperty("network")]
        [STJS.JsonPropertyName("network")]
        public ActivityLogDetailsUserAccessNetwork Network { get; set; }

        /// <summary>
        /// Risk details for the user access action.
        /// </summary>
        [JsonProperty("risk")]
        [STJS.JsonPropertyName("risk")]
        public ActivityLogDetailsUserAccessRisk Risk { get; set; }

        /// <summary>
        /// Roles associated with the user access action.
        /// </summary>
        [JsonProperty("roles")]
        [STJS.JsonPropertyName("roles")]
        public List<string> Roles { get; set; }

        /// <summary>
        /// Session fingerprint for the user access action.
        /// </summary>
        [JsonProperty("session_fingerprint")]
        [STJS.JsonPropertyName("session_fingerprint")]
        public string SessionFingerprint { get; set; }

        /// <summary>
        /// Surface where the user access action started.
        /// One of: <c>dashboard</c>, or <c>express</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("surface")]
        [STJS.JsonPropertyName("surface")]
        public string Surface { get; set; }
    }
}
