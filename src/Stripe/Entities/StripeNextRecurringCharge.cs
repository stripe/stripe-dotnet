using System;
using Newtonsoft.Json;
using Stripe.Infrastructure;

namespace Stripe
{
    public class StripeNextRecurringCharge
    {
        [JsonProperty("amount")]
        public string AmountInCents { get; set; }

		[JsonProperty("date")]
		[JsonConverter(typeof(StripeDateTimeConverter))]
        public DateTime? Date { get; set; }
    }
}
