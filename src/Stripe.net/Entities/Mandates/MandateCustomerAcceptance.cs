namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class MandateCustomerAcceptance : StripeEntity<MandateCustomerAcceptance>
    {
        [JsonProperty("accepted_at")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime? AcceptedAt { get; set; }

        [JsonProperty("offline")]
        public MandateCustomerAcceptanceOffline Offline { get; set; }

        [JsonProperty("online")]
        public MandateCustomerAcceptanceOnline Online { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
