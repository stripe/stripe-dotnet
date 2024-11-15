// File generated from our OpenAPI spec
namespace Stripe.Tax
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class RegistrationUpdateOptions : BaseOptions
    {
        /// <summary>
        /// Time at which the registration becomes active. It can be either <c>now</c> to indicate
        /// the current time, or a timestamp measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("active_from")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("active_from")]
#endif

        [JsonConverter(typeof(AnyOfConverter))]
        public AnyOf<DateTime?, RegistrationActiveFrom> ActiveFrom { get; set; }

        /// <summary>
        /// If set, the registration stops being active at this time. If not set, the registration
        /// will be active indefinitely. It can be either <c>now</c> to indicate the current time,
        /// or a timestamp measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("expires_at")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("expires_at")]
#endif

        [JsonConverter(typeof(AnyOfConverter))]
        public AnyOf<DateTime?, RegistrationExpiresAt> ExpiresAt { get; set; }
    }
}
