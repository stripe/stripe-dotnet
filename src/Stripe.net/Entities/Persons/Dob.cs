namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class Dob : StripeEntity<Dob>
    {
        [JsonProperty("day")]
        public long? Day { get; set; }

        [JsonProperty("month")]
        public long? Month { get; set; }

        [JsonProperty("year")]
        public long? Year { get; set; }
    }
}
