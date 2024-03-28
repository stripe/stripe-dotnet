// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class AccountRequirementsError : StripeEntity<AccountRequirementsError>
    {
        /// <summary>
        /// The code for the type of error.
        /// One of: <c>invalid_address_city_state_postal_code</c>,
        /// <c>invalid_address_highway_contract_box</c>, <c>invalid_address_private_mailbox</c>,
        /// <c>invalid_business_profile_name</c>, <c>invalid_business_profile_name_denylisted</c>,
        /// <c>invalid_company_name_denylisted</c>, <c>invalid_dob_age_over_maximum</c>,
        /// <c>invalid_dob_age_under_18</c>, <c>invalid_dob_age_under_minimum</c>,
        /// <c>invalid_product_description_length</c>, <c>invalid_product_description_url_match</c>,
        /// <c>invalid_representative_country</c>,
        /// <c>invalid_statement_descriptor_business_mismatch</c>,
        /// <c>invalid_statement_descriptor_denylisted</c>,
        /// <c>invalid_statement_descriptor_length</c>,
        /// <c>invalid_statement_descriptor_prefix_denylisted</c>,
        /// <c>invalid_statement_descriptor_prefix_mismatch</c>, <c>invalid_street_address</c>,
        /// <c>invalid_tax_id</c>, <c>invalid_tax_id_format</c>, <c>invalid_tos_acceptance</c>,
        /// <c>invalid_url_denylisted</c>, <c>invalid_url_format</c>, <c>invalid_url_length</c>,
        /// <c>invalid_url_web_presence_detected</c>,
        /// <c>invalid_url_website_business_information_mismatch</c>,
        /// <c>invalid_url_website_empty</c>, <c>invalid_url_website_inaccessible</c>,
        /// <c>invalid_url_website_inaccessible_geoblocked</c>,
        /// <c>invalid_url_website_inaccessible_password_protected</c>,
        /// <c>invalid_url_website_incomplete</c>,
        /// <c>invalid_url_website_incomplete_cancellation_policy</c>,
        /// <c>invalid_url_website_incomplete_customer_service_details</c>,
        /// <c>invalid_url_website_incomplete_legal_restrictions</c>,
        /// <c>invalid_url_website_incomplete_refund_policy</c>,
        /// <c>invalid_url_website_incomplete_return_policy</c>,
        /// <c>invalid_url_website_incomplete_terms_and_conditions</c>,
        /// <c>invalid_url_website_incomplete_under_construction</c>,
        /// <c>invalid_url_website_other</c>, <c>invalid_value_other</c>,
        /// <c>verification_directors_mismatch</c>, <c>verification_document_address_mismatch</c>,
        /// <c>verification_document_address_missing</c>, <c>verification_document_corrupt</c>,
        /// <c>verification_document_country_not_supported</c>,
        /// <c>verification_document_directors_mismatch</c>,
        /// <c>verification_document_dob_mismatch</c>, <c>verification_document_duplicate_type</c>,
        /// <c>verification_document_expired</c>, <c>verification_document_failed_copy</c>,
        /// <c>verification_document_failed_greyscale</c>,
        /// <c>verification_document_failed_other</c>,
        /// <c>verification_document_failed_test_mode</c>, <c>verification_document_fraudulent</c>,
        /// <c>verification_document_id_number_mismatch</c>,
        /// <c>verification_document_id_number_missing</c>, <c>verification_document_incomplete</c>,
        /// <c>verification_document_invalid</c>,
        /// <c>verification_document_issue_or_expiry_date_missing</c>,
        /// <c>verification_document_manipulated</c>, <c>verification_document_missing_back</c>,
        /// <c>verification_document_missing_front</c>, <c>verification_document_name_mismatch</c>,
        /// <c>verification_document_name_missing</c>,
        /// <c>verification_document_nationality_mismatch</c>,
        /// <c>verification_document_not_readable</c>, <c>verification_document_not_signed</c>,
        /// <c>verification_document_not_uploaded</c>, <c>verification_document_photo_mismatch</c>,
        /// <c>verification_document_too_large</c>, <c>verification_document_type_not_supported</c>,
        /// <c>verification_extraneous_directors</c>, <c>verification_failed_address_match</c>,
        /// <c>verification_failed_business_iec_number</c>,
        /// <c>verification_failed_document_match</c>, <c>verification_failed_id_number_match</c>,
        /// <c>verification_failed_keyed_identity</c>, <c>verification_failed_keyed_match</c>,
        /// <c>verification_failed_name_match</c>, <c>verification_failed_other</c>,
        /// <c>verification_failed_representative_authority</c>,
        /// <c>verification_failed_residential_address</c>, <c>verification_failed_tax_id_match</c>,
        /// <c>verification_failed_tax_id_not_issued</c>, <c>verification_missing_directors</c>,
        /// <c>verification_missing_executives</c>, <c>verification_missing_owners</c>, or
        /// <c>verification_requires_additional_memorandum_of_associations</c>.
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
