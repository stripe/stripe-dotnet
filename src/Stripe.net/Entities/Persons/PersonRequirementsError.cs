namespace Stripe
{
    using Newtonsoft.Json;

    public class PersonRequirementsError : StripeEntity<PersonRequirementsError>
    {
        /// <summary>
        /// The code for the type of error.
        /// One of: <c>invalid_address_city_state_postal_code</c>, <c>invalid_street_address</c>,
        /// <c>invalid_value_other</c>, <c>verification_document_address_mismatch</c>,
        /// <c>verification_document_address_missing</c>, <c>verification_document_corrupt</c>,
        /// <c>verification_document_country_not_supported</c>,
        /// <c>verification_document_dob_mismatch</c>, <c>verification_document_duplicate_type</c>,
        /// <c>verification_document_expired</c>, <c>verification_document_failed_copy</c>,
        /// <c>verification_document_failed_greyscale</c>,
        /// <c>verification_document_failed_other</c>,
        /// <c>verification_document_failed_test_mode</c>, <c>verification_document_fraudulent</c>,
        /// <c>verification_document_id_number_mismatch</c>,
        /// <c>verification_document_id_number_missing</c>, <c>verification_document_incomplete</c>,
        /// <c>verification_document_invalid</c>, <c>verification_document_manipulated</c>,
        /// <c>verification_document_missing_back</c>, <c>verification_document_missing_front</c>,
        /// <c>verification_document_name_mismatch</c>, <c>verification_document_name_missing</c>,
        /// <c>verification_document_nationality_mismatch</c>,
        /// <c>verification_document_not_readable</c>, <c>verification_document_not_uploaded</c>,
        /// <c>verification_document_photo_mismatch</c>, <c>verification_document_too_large</c>,
        /// <c>verification_document_type_not_supported</c>,
        /// <c>verification_failed_address_match</c>,
        /// <c>verification_failed_business_iec_number</c>,
        /// <c>verification_failed_document_match</c>, <c>verification_failed_id_number_match</c>,
        /// <c>verification_failed_keyed_identity</c>, <c>verification_failed_keyed_match</c>,
        /// <c>verification_failed_name_match</c>, or <c>verification_failed_other</c>.
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
