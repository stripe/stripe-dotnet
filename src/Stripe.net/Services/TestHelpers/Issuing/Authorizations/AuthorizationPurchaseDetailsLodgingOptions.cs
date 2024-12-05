// File generated from our OpenAPI spec
namespace Stripe.TestHelpers.Issuing
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AuthorizationPurchaseDetailsLodgingOptions : INestedOptions
    {
        /// <summary>
        /// The time of checking into the lodging.
        /// </summary>
        [JsonProperty("check_in_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("check_in_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif
        public DateTime? CheckInAt { get; set; }

        /// <summary>
        /// The number of nights stayed at the lodging.
        /// </summary>
        [JsonProperty("nights")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("nights")]
#endif
        public long? Nights { get; set; }
    }
}
