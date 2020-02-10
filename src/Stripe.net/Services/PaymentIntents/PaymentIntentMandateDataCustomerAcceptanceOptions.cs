namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class PaymentIntentMandateDataCustomerAcceptanceOptions : INestedOptions
    {
        [JsonProperty("accepted_at")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime? AcceptedAt { get; set; }

        [JsonProperty("offline")]
        public PaymentIntentMandateDataCustomerAcceptanceOfflineOptions Offline { get; set; }

        [JsonProperty("online")]
        public PaymentIntentMandateDataCustomerAcceptanceOnlineOptions Online { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
