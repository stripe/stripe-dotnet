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
        /// <c>document_name_mismatch</c>, <c>failed_keyed_identity</c>, or
        /// <c>failed_other</c>.
        /// </summary>
        [JsonProperty("details_code")]
        public string DetailsCode { get; set; }

        /// <summary>
        /// An identifying document for this individual, either a passport or local ID card.
        /// </summary>
        [JsonProperty("document")]
        public PersonVerificationDocument Document { get; set; }

        /// <summary>
        /// The state of verification for this person. Possible values are <c>unverified</c>,
        /// <c>pending</c>, or <c>verified</c>.
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }
    }
}
