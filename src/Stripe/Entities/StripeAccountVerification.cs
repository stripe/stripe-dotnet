using System;
using Newtonsoft.Json;

using Stripe.Infrastructure;

namespace Stripe
{
    public class StripeAccountVerification
    {
        //Read Only Property
        [JsonProperty("disabled_reason")]
        public string DisabledReason { get; set; }

        //Read Only Property
        [JsonProperty("due_by")]
        [JsonConverter(typeof(StripeDateTimeConverter))]
        public DateTime? DueBy { get; set; }

        //Read Only Property
        [JsonProperty("fields_needed")]
        public string[] FieldsNeeded { get; set; }

    }
}
