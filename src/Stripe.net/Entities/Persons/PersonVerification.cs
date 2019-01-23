namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class PersonVerification : StripeEntity<PersonVerification>
    {
        /// <summary>
        /// A user-displayable string describing the verification state for this person. For
        /// example, if a document is uploaded and the picture is too fuzzy, this may say “Identity
        /// document is too unclear to read”.
        /// </summary>
        [JsonProperty("details")]
        public string Details { get; set; }

        /// <summary>
        /// A machine-readable code specifying the verification state for this person. One of
        /// <code>document_name_mismatch</code>, <code>failed_keyed_identity</code>, or
        /// <code>failed_other</code>.
        /// </summary>
        [JsonProperty("details_code")]
        public string DetailsCode { get; set; }

        /// <summary>
        /// An identifying document for this individual, either a passport or local ID card.
        /// </summary>
        [JsonProperty("document")]
        public PersonVerificationDocument Document { get; set; }

        /// <summary>
        /// The state of verification for this person. Possible values are <code>unverified</code>,
        /// <code>pending</code>, or <code>verified</code>.
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }
    }
}
