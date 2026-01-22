// File generated from our OpenAPI spec
namespace Stripe.Radar
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentEvaluationOutcomeRejectedCard : StripeEntity<PaymentEvaluationOutcomeRejectedCard>
    {
        /// <summary>
        /// Result of the address line 1 check.
        /// One of: <c>fail</c>, <c>pass</c>, <c>unavailable</c>, or <c>unchecked</c>.
        /// </summary>
        [JsonProperty("address_line1_check")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("address_line1_check")]
#endif
        public string AddressLine1Check { get; set; }

        /// <summary>
        /// Indicates whether the cardholder provided a postal code and if it matched the
        /// cardholder’s billing address.
        /// One of: <c>fail</c>, <c>pass</c>, <c>unavailable</c>, or <c>unchecked</c>.
        /// </summary>
        [JsonProperty("address_postal_code_check")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("address_postal_code_check")]
#endif
        public string AddressPostalCodeCheck { get; set; }

        /// <summary>
        /// Result of the CVC check.
        /// One of: <c>fail</c>, <c>pass</c>, <c>unavailable</c>, or <c>unchecked</c>.
        /// </summary>
        [JsonProperty("cvc_check")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("cvc_check")]
#endif
        public string CvcCheck { get; set; }

        /// <summary>
        /// Card issuer's reason for the network decline.
        /// One of: <c>authentication_failed</c>, <c>do_not_honor</c>, <c>expired</c>,
        /// <c>incorrect_cvc</c>, <c>incorrect_number</c>, <c>incorrect_postal_code</c>,
        /// <c>insufficient_funds</c>, <c>invalid_account</c>, <c>lost_card</c>, <c>other</c>,
        /// <c>processing_error</c>, <c>reported_stolen</c>, or <c>try_again_later</c>.
        /// </summary>
        [JsonProperty("reason")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("reason")]
#endif
        public string Reason { get; set; }
    }
}
