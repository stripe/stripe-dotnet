namespace Stripe.Issuing
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class TransactionPurchaseDetailsFlight : StripeEntity<TransactionPurchaseDetailsFlight>
    {
        [JsonProperty("departure_at")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime? DepartureAt { get; set; }

        [JsonProperty("passenger_name")]
        public string PassengerName { get; set; }

        [JsonProperty("refundable")]
        public bool? Refundable { get; set; }

        [JsonProperty("segments")]
        public List<TransactionPurchaseDetailsFlightSegment> Segments { get; set; }

        [JsonProperty("travel_agency")]
        public string TravelAgency { get; set; }
    }
}
