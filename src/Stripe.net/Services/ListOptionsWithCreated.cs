namespace Stripe
{
    using System;
    using Newtonsoft.Json;

    public class ListOptionsWithCreated : ListOptions
    {
        [JsonProperty("created")]
        public DateTime? Created { get; set; }

        [JsonProperty("created")]
        public DateRangeOptions CreatedRange { get; set; }
    }
}
