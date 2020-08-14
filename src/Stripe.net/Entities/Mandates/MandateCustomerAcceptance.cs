namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class MandateCustomerAcceptance : StripeEntity<MandateCustomerAcceptance>
    {
        /// <summary>
        /// The time at which the customer accepted the Mandate.
        /// </summary>
        [JsonProperty("accepted_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? AcceptedAt { get; set; }

        [JsonProperty("offline")]
        public MandateCustomerAcceptanceOffline Offline { get; set; }

        [JsonProperty("online")]
        public MandateCustomerAcceptanceOnline Online { get; set; }

        /// <summary>
        /// The type of customer acceptance information included with the Mandate. One of
        /// <c>online</c> or <c>offline</c>.
        /// One of: <c>offline</c>, or <c>online</c>.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
