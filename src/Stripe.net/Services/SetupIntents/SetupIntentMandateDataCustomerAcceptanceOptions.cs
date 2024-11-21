// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class SetupIntentMandateDataCustomerAcceptanceOptions : INestedOptions
    {
        /// <summary>
        /// The time at which the customer accepted the Mandate.
        /// </summary>
        [JsonProperty("accepted_at")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("accepted_at")]
#endif

        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif

        public DateTime? AcceptedAt { get; set; }

        /// <summary>
        /// If this is a Mandate accepted offline, this hash contains details about the offline
        /// acceptance.
        /// </summary>
        [JsonProperty("offline")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("offline")]
#endif

        public SetupIntentMandateDataCustomerAcceptanceOfflineOptions Offline { get; set; }

        /// <summary>
        /// If this is a Mandate accepted online, this hash contains details about the online
        /// acceptance.
        /// </summary>
        [JsonProperty("online")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("online")]
#endif

        public SetupIntentMandateDataCustomerAcceptanceOnlineOptions Online { get; set; }

        /// <summary>
        /// The type of customer acceptance information included with the Mandate. One of
        /// <c>online</c> or <c>offline</c>.
        /// One of: <c>offline</c>, or <c>online</c>.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif

        public string Type { get; set; }
    }
}
