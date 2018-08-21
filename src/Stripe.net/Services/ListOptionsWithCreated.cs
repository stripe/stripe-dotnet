namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class ListOptionsWithCreated : ListOptions
    {
        [JsonProperty("created")]
        public DateTime? Created { get; set; }

        [JsonProperty("created")]
        internal string CreatedInternal => this.Created?.ConvertDateTimeToEpoch().ToString();

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
