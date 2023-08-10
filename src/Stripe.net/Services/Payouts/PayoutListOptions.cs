// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;

/* Unmerged change from project 'Stripe.net(netcoreapp3.1)'
Before:
    using Stripe.Infrastructure;
    using Newtonsoft.Json.Converters;
After:
    using Newtonsoft.Json.Converters;
    using Stripe.Infrastructure;
*/
    using Newtonsoft.Json.Converters;
    using Stripe.Infrastructure;

    public class PayoutListOptions : ListOptionsWithCreated
    {
        [JsonProperty("arrival_date")]
        [JsonConverter(typeof(AnyOfConverter))]
        public AnyOf<DateTime?, DateRangeOptions> ArrivalDate { get; set; }

        [JsonProperty("destination")]
        public string Destination { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }
    }
}
