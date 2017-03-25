﻿using System;
using Newtonsoft.Json;
using Stripe.Infrastructure;

namespace Stripe
{
    public class StripePayoutListOptions : StripeListOptions
    {
        [JsonProperty("amount")]
        public int? Amount { get; set; }

        public DateTime? ArrivalDate { get; set; }

        [JsonProperty("arrival_date")]
        internal string ArrivalDateInternal => ArrivalDate?.ConvertDateTimeToEpoch().ToString();

        public DateTime? Created { get; set; }

        [JsonProperty("created")]
        internal string CreatedInternal => Created?.ConvertDateTimeToEpoch().ToString();

        [JsonProperty("destination")]
        public string Destination { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }
}
