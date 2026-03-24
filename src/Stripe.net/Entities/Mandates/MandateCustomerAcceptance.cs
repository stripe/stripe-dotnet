// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class MandateCustomerAcceptance : StripeEntity<MandateCustomerAcceptance>
    {
        /// <summary>
        /// The time that the customer accepts the mandate.
        /// </summary>
        [JsonProperty("accepted_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("accepted_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime? AcceptedAt { get; set; }

        [JsonProperty("offline")]
        [STJS.JsonPropertyName("offline")]
        public MandateCustomerAcceptanceOffline Offline { get; set; }

        [JsonProperty("online")]
        [STJS.JsonPropertyName("online")]
        public MandateCustomerAcceptanceOnline Online { get; set; }

        /// <summary>
        /// The mandate includes the type of customer acceptance information, such as: <c>online</c>
        /// or <c>offline</c>.
        /// One of: <c>offline</c>, or <c>online</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
