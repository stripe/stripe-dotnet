namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class CardholderIndividualDob : StripeEntity<CardholderIndividualDob>
    {
        [JsonProperty("day")]
        public long? Day { get; set; }

        [JsonProperty("month")]
        public long? Month { get; set; }

        [JsonProperty("year")]
        public long? Year { get; set; }
    }
}
