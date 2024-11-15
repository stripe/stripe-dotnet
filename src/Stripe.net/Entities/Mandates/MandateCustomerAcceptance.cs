// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class MandateCustomerAcceptance : StripeEntity<MandateCustomerAcceptance>
    {
        /// <summary>
        /// The time that the customer accepts the mandate.
        /// </summary>
        [JsonProperty("accepted_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("accepted_at")]
#endif

        public DateTime? AcceptedAt { get; set; }

        [JsonProperty("offline")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("offline")]
#endif

        public MandateCustomerAcceptanceOffline Offline { get; set; }

        [JsonProperty("online")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("online")]
#endif

        public MandateCustomerAcceptanceOnline Online { get; set; }

        /// <summary>
        /// The mandate includes the type of customer acceptance information, such as: <c>online</c>
        /// or <c>offline</c>.
        /// One of: <c>offline</c>, or <c>online</c>.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif

        public string Type { get; set; }
    }
}
