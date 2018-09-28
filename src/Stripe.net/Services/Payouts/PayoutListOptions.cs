﻿namespace Stripe
{
    using System;
    using Stripe.Infrastructure;

    public class PayoutListOptions : ListOptions
    {
        [FormProperty("arrival_date")]
        public DateFilter ArrivalDate { get; set; }

        [FormProperty("created")]
        public DateFilter Created { get; set; }

        [FormProperty("destination")]
        public string Destination { get; set; }

        [FormProperty("status")]
        public string Status { get; set; }
    }
}
