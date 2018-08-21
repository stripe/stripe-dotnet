﻿namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class PayoutListOptions : ListOptions
    {
        [JsonProperty("arrival_date")]
        public DateFilter ArrivalDate { get; set; }

        [JsonProperty("created")]
        public DateFilter Created { get; set; }

        [JsonProperty("destination")]
        public string Destination { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }
}
