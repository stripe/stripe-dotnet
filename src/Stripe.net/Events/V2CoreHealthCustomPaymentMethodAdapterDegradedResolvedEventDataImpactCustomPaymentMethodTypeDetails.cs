// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System;
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    public class V2CoreHealthCustomPaymentMethodAdapterDegradedResolvedEventDataImpactCustomPaymentMethodTypeDetails : StripeEntity<V2CoreHealthCustomPaymentMethodAdapterDegradedResolvedEventDataImpactCustomPaymentMethodTypeDetails>
    {
        /// <summary>
        /// The time when the custom payment method was automatically disabled. Null when it is
        /// enabled.
        /// </summary>
        [JsonProperty("auto_disabled_at")]
        [STJS.JsonPropertyName("auto_disabled_at")]
        public DateTime? AutoDisabledAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// The display name of the custom payment method type.
        /// </summary>
        [JsonProperty("display_name")]
        [STJS.JsonPropertyName("display_name")]
        public string DisplayName { get; set; }

        /// <summary>
        /// The URL of the user's self-hosted adapter endpoint.
        /// </summary>
        [JsonProperty("reverse_api_url")]
        [STJS.JsonPropertyName("reverse_api_url")]
        public string ReverseApiUrl { get; set; }

        /// <summary>
        /// The identifier of the custom payment method type (e.g., "cpmt_...").
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
