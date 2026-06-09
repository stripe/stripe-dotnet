// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class DisputeProvisionalCreditOptions : INestedOptions
    {
        /// <summary>
        /// The time at which the platform granted the provisional credit to their user.
        /// </summary>
        [JsonProperty("granted_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("granted_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime? GrantedAt { get; set; }

        /// <summary>
        /// The time at which the platform revoked the provisional credit from their user.
        /// </summary>
        [JsonProperty("revoked_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("revoked_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime? RevokedAt { get; set; }
    }
}
