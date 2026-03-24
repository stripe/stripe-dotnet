// File generated from our OpenAPI spec
namespace Stripe.DelegatedCheckout
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class RequestedSessionAffiliateAttributionOptions : INestedOptions
    {
        /// <summary>
        /// Agent-scoped campaign identifier.
        /// </summary>
        [JsonProperty("campaign_id")]
        [STJS.JsonPropertyName("campaign_id")]
        public string CampaignId { get; set; }

        /// <summary>
        /// Agent-scoped creative identifier.
        /// </summary>
        [JsonProperty("creative_id")]
        [STJS.JsonPropertyName("creative_id")]
        public string CreativeId { get; set; }

        /// <summary>
        /// Timestamp when the attribution token expires.
        /// </summary>
        [JsonProperty("expires_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("expires_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime? ExpiresAt { get; set; }

        /// <summary>
        /// Agent-issued secret to validate the legitimacy of the source of this data.
        /// </summary>
        [JsonProperty("identification_token")]
        [STJS.JsonPropertyName("identification_token")]
        public string IdentificationToken { get; set; }

        /// <summary>
        /// Timestamp for when the attribution token was issued.
        /// </summary>
        [JsonProperty("issued_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("issued_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime? IssuedAt { get; set; }

        /// <summary>
        /// Identifier for the attribution agent / affiliate network namespace.
        /// </summary>
        [JsonProperty("provider")]
        [STJS.JsonPropertyName("provider")]
        public string Provider { get; set; }

        /// <summary>
        /// Agent-scoped affiliate/publisher identifier.
        /// </summary>
        [JsonProperty("publisher_id")]
        [STJS.JsonPropertyName("publisher_id")]
        public string PublisherId { get; set; }

        /// <summary>
        /// Freeform key/value pairs for additional non-sensitive per-agent data.
        /// </summary>
        [JsonProperty("shared_metadata")]
        [STJS.JsonPropertyName("shared_metadata")]
        public Dictionary<string, string> SharedMetadata { get; set; }

        /// <summary>
        /// Context about where the attribution originated.
        /// </summary>
        [JsonProperty("source")]
        [STJS.JsonPropertyName("source")]
        public RequestedSessionAffiliateAttributionSourceOptions Source { get; set; }

        /// <summary>
        /// Agent-scoped sub-tracking identifier.
        /// </summary>
        [JsonProperty("sub_id")]
        [STJS.JsonPropertyName("sub_id")]
        public string SubId { get; set; }

        /// <summary>
        /// Whether this is the first or last touchpoint.
        /// One of: <c>first</c>, or <c>last</c>.
        /// </summary>
        [JsonProperty("touchpoint")]
        [STJS.JsonPropertyName("touchpoint")]
        public string Touchpoint { get; set; }
    }
}
