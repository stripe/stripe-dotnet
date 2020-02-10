namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class SetupIntentMandateDataCustomerAcceptanceOptions : INestedOptions
    {
        [JsonProperty("accepted_at")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime? AcceptedAt { get; set; }

        [JsonProperty("offline")]
        public SetupIntentMandateDataCustomerAcceptanceOfflineOptions Offline { get; set; }

        [JsonProperty("online")]
        public SetupIntentMandateDataCustomerAcceptanceOnlineOptions Online { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
