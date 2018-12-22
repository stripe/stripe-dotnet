namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class AccountVerification : StripeEntity
    {
        [JsonProperty("disabled_reason")]
        public string DisabledReason { get; set; }

        [JsonProperty("due_by")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime? DueBy { get; set; }

        [JsonProperty("fields_needed")]
        public List<string> FieldsNeeded { get; set; }
    }
}
