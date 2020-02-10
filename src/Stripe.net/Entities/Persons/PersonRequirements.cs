namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class PersonRequirements : StripeEntity<PersonRequirements>
    {
        [JsonProperty("currently_due")]
        public List<string> CurrentlyDue { get; set; }

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
