// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class FundingIntentNextActionProvideNewImagesAmountIssue : StripeEntity<FundingIntentNextActionProvideNewImagesAmountIssue>
    {
        /// <summary>
        /// A human-readable description of the factor.
        /// </summary>
        [JsonProperty("description")]
        [STJS.JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// A machine-readable reason for the factor.
        /// One of: <c>amount_variance_exceeds_threshold</c>,
        /// <c>amount_variance_nearing_threshold</c>, <c>back_image_not_processed</c>,
        /// <c>back_looks_like_front</c>, <c>back_signature_not_detected</c>, <c>bad_payee_name</c>,
        /// <c>date_invalid</c>, <c>date_in_future</c>, <c>date_older_than_one_year</c>,
        /// <c>date_older_than_six_months</c>, <c>duplicate_check</c>, <c>endorsement_missing</c>,
        /// <c>folded_or_torn_corners</c>, <c>front_image_dimension_mismatch</c>,
        /// <c>front_image_not_processed</c>, <c>front_image_too_dark</c>,
        /// <c>front_image_too_light</c>, <c>front_image_too_small</c>,
        /// <c>front_signature_not_detected</c>, <c>high_risk</c>, <c>image_cannot_be_processed</c>,
        /// <c>image_out_of_focus</c>, <c>invalid_check_type</c>, <c>invalid_routing_number</c>,
        /// <c>not_accepted_please_contact</c>, <c>no_routing_number_detected</c>,
        /// <c>safe_harbor_phrase_missing</c>, <c>savings_bond_detected</c>, <c>travelers_check</c>,
        /// or <c>unable_to_read_account_info</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("reason")]
        [STJS.JsonPropertyName("reason")]
        public string Reason { get; set; }
    }
}
