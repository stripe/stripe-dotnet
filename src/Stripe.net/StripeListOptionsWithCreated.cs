using System;
using Newtonsoft.Json;
using Stripe.Infrastructure;

namespace Stripe.net
{
    public class StripeListOptionsWithCreated : StripeListOptions
    {
        [JsonProperty("created")]
        public DateTime? Created { get; set; }

        [JsonProperty("created")]
        internal string CreatedInternal => Created?.ConvertDateTimeToEpoch().ToString();

        [JsonProperty("created[gt]")]
        public DateTime? GreaterThan { get; set; }

        [JsonProperty("created[gte]")]
        public DateTime? GreaterThanOrEqual { get; set; }

        [JsonProperty("created[lt]")]
        public DateTime? LessThan { get; set; }

        [JsonProperty("created[lte]")]
        public DateTime? LessThanOrEqual { get; set; }
    }
}
