namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class Period : StripeEntity<Period>
    {
        [JsonProperty("start")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime? Start { get; set; }

        [JsonProperty("end")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime? End { get; set; }
    }
}
