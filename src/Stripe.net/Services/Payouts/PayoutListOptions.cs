namespace Stripe
{
    using System;
    using Newtonsoft.Json;

    public class PayoutListOptions : ListOptionsWithCreated
    {
        [JsonProperty("arrival_date")]
        public DateTime? ArrivalDate { get; set; }

        [JsonProperty("arrival_date")]
        public DateRangeOptions ArrivalDateRange { get; set; }

        [JsonProperty("destination")]
        public string Destination { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }
}
