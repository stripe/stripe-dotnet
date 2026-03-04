// File generated from our OpenAPI spec
namespace Stripe.DelegatedCheckout
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class RequestedSessionAffiliateAttribution : StripeEntity<RequestedSessionAffiliateAttribution>
    {
        /// <summary>
        /// Agent-scoped campaign identifier.
        /// </summary>
        [JsonProperty("campaign_id")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("campaign_id")]
#endif
        public string CampaignId { get; set; }

        /// <summary>
        /// Agent-scoped creative identifier.
        /// </summary>
        [JsonProperty("creative_id")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("creative_id")]
#endif
        public string CreativeId { get; set; }

        /// <summary>
        /// Timestamp when the attribution token expires.
        /// </summary>
        [JsonProperty("expires_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("expires_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif
        public DateTime ExpiresAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Agent-issued secret to validate the legitimacy of the source of this data.
        /// </summary>
        [JsonProperty("identification_token")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("identification_token")]
#endif
        public string IdentificationToken { get; set; }

        /// <summary>
        /// Timestamp for when the attribution token was issued.
        /// </summary>
        [JsonProperty("issued_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("issued_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif
        public DateTime IssuedAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Identifier for the attribution agent / affiliate network namespace.
        /// </summary>
        [JsonProperty("provider")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("provider")]
#endif
        public string Provider { get; set; }

        /// <summary>
        /// Agent-scoped affiliate/publisher identifier.
        /// </summary>
        [JsonProperty("publisher_id")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("publisher_id")]
#endif
        public string PublisherId { get; set; }

        /// <summary>
        /// Freeform key/value pairs for additional non-sensitive per-agent data.
        /// </summary>
        [JsonProperty("shared_metadata")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("shared_metadata")]
#endif
        public Dictionary<string, string> SharedMetadata { get; set; }

        /// <summary>
        /// Context about where the attribution originated.
        /// </summary>
        [JsonProperty("source")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("source")]
#endif
        public RequestedSessionAffiliateAttributionSource Source { get; set; }

        /// <summary>
        /// Agent-scoped sub-tracking identifier.
        /// </summary>
        [JsonProperty("sub_id")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("sub_id")]
#endif
        public string SubId { get; set; }

        /// <summary>
        /// Whether this is the first or last touchpoint.
        /// One of: <c>first</c>, or <c>last</c>.
        /// </summary>
        [JsonProperty("touchpoint")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("touchpoint")]
#endif
        public string Touchpoint { get; set; }
    }
}
