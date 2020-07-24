namespace Stripe
{
    using Newtonsoft.Json;

    public class PersonRequirementsError : StripeEntity<PersonRequirementsError>
    {
        /// <summary>
        /// The code for the type of error.
        /// </summary>
        [JsonProperty("code")]
        public string Code { get; set; }

        /// <summary>
        /// An informative message that indicates the error type and provides additional details
        /// about the error.
        /// </summary>
        [JsonProperty("reason")]
        public string Reason { get; set; }

        /// <summary>
        /// The specific user onboarding requirement field (in the requirements hash) that needs to
        /// be resolved.
        /// </summary>
        [JsonProperty("requirement")]
        public string Requirement { get; set; }
    }
}
