// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class SetupIntentMandateDataCustomerAcceptanceOptions : INestedOptions
    {
        /// <summary>
        /// The time at which the customer accepted the Mandate.
        /// </summary>
        [JsonProperty("accepted_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("accepted_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime? AcceptedAt { get; set; }

        /// <summary>
        /// If this is a Mandate accepted offline, this hash contains details about the offline
        /// acceptance.
        /// </summary>
        [JsonProperty("offline")]
        [STJS.JsonPropertyName("offline")]
        public SetupIntentMandateDataCustomerAcceptanceOfflineOptions Offline { get; set; }

        /// <summary>
        /// If this is a Mandate accepted online, this hash contains details about the online
        /// acceptance.
        /// </summary>
        [JsonProperty("online")]
        [STJS.JsonPropertyName("online")]
        public SetupIntentMandateDataCustomerAcceptanceOnlineOptions Online { get; set; }

        /// <summary>
        /// The type of customer acceptance information included with the Mandate. One of
        /// <c>online</c> or <c>offline</c>.
        /// One of: <c>offline</c>, or <c>online</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
