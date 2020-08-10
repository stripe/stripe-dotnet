namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class PersonRequirements : StripeEntity<PersonRequirements>
    {
        [JsonProperty("currently_due")]
        public List<string> CurrentlyDue { get; set; }

        [JsonProperty("errors")]
        public List<PersonRequirementsError> Errors { get; set; }

        [JsonProperty("eventually_due")]
        public List<string> EventuallyDue { get; set; }

        [JsonProperty("past_due")]
        public List<string> PastDue { get; set; }

        [JsonProperty("pending_verification")]
        public List<string> PendingVerification { get; set; }
    }
}
