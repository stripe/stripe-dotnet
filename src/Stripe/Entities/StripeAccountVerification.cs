using System;
using Newtonsoft.Json;
using Stripe.Infrastructure;

namespace Stripe.Entities
{
    public class StripeAccountVerification
    {
        [JsonProperty("contacted")]
        public bool Contacted { get; set; }

        [JsonProperty("fields_needed")]
        public string[] FieldsNeeded { get; set; }

        [JsonProperty("due_by")]
        [JsonConverter(typeof(StripeDateTimeConverter))]
        public DateTime? DueBy { get; set; }
    }

    public class StripeLegalEntityVerification
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("document")]
        public string Document { get; set; }

        [JsonProperty("details")]
        public string Details { get; set; }
    }
}
