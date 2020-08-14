namespace Stripe
{
    using Newtonsoft.Json;

    public class PersonVerification : StripeEntity<PersonVerification>
    {
        /// <summary>
        /// A document showing address, either a passport, local ID card, or utility bill from a
        /// well-known utility company.
        /// </summary>
        [JsonProperty("additional_document")]
        public PersonVerificationAdditionalDocument AdditionalDocument { get; set; }

        /// <summary>
        /// A user-displayable string describing the verification state for the person. For example,
        /// this may say "Provided identity information could not be verified".
        /// </summary>
        [JsonProperty("details")]
        public string Details { get; set; }

        /// <summary>
        /// One of <c>document_address_mismatch</c>, <c>document_dob_mismatch</c>,
        /// <c>document_duplicate_type</c>, <c>document_id_number_mismatch</c>,
        /// <c>document_name_mismatch</c>, <c>document_nationality_mismatch</c>,
        /// <c>failed_keyed_identity</c>, or <c>failed_other</c>. A machine-readable code specifying
        /// the verification state for the person.
        /// </summary>
        [JsonProperty("details_code")]
        public string DetailsCode { get; set; }

        [JsonProperty("document")]
        public PersonVerificationDocument Document { get; set; }

        /// <summary>
        /// The state of verification for the person. Possible values are <c>unverified</c>,
        /// <c>pending</c>, or <c>verified</c>.
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }
    }
}
