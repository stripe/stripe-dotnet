namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class AccountRequirements : StripeEntity<AccountRequirements>
    {
        [JsonProperty("current_deadline")]
        [JsonConverter(typeof(DateTimeConverter))]
        public DateTime? CurrentDeadline { get; set; }

        [JsonProperty("currently_due")]
        public List<string> CurrentlyDue { get; set; }

        [JsonProperty("disabled_reason")]
        public string DisabledReason { get; set; }

        [JsonProperty("errors")]
        public List<AccountRequirementsError> Errors { get; set; }

        [JsonProperty("eventually_due")]
        public List<string> EventuallyDue { get; set; }

        [JsonProperty("past_due")]
        public List<string> PastDue { get; set; }

        [JsonProperty("pending_verification")]
        public List<string> PendingVerification { get; set; }
    }
}
