// File generated from our OpenAPI spec
namespace Stripe.TestHelpers.Issuing
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AuthorizationPurchaseDetailsLodgingOptions : INestedOptions
    {
        /// <summary>
        /// The time of checking into the lodging.
        /// </summary>
        [JsonProperty("check_in_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("check_in_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime? CheckInAt { get; set; }

        /// <summary>
        /// The number of nights stayed at the lodging.
        /// </summary>
        [JsonProperty("nights")]
        [STJS.JsonPropertyName("nights")]
        public long? Nights { get; set; }
    }
}
