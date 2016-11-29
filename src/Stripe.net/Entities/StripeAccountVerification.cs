using System;
using Newtonsoft.Json;
using Stripe.Infrastructure;

namespace Stripe
{
    public class StripeAccountVerification : StripeEntity
    {
        [JsonProperty("disabled_reason")]
        public string DisabledReason { get; set; }

        [JsonProperty("due_by")]
        [JsonConverter(typeof(StripeDateTimeConverter))]
        public DateTime? DueBy { get; set; }

        [JsonProperty("fields_needed")]
        public string[] FieldsNeeded { get; set; }
    }
}
