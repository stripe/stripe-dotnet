// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class DisputeEvidence : StripeEntity<DisputeEvidence>
    {
        [JsonProperty("canceled")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("canceled")]
#endif
        public DisputeEvidenceCanceled Canceled { get; set; }

        [JsonProperty("duplicate")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("duplicate")]
#endif
        public DisputeEvidenceDuplicate Duplicate { get; set; }

        [JsonProperty("fraudulent")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("fraudulent")]
#endif
        public DisputeEvidenceFraudulent Fraudulent { get; set; }

        [JsonProperty("merchandise_not_as_described")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("merchandise_not_as_described")]
#endif
        public DisputeEvidenceMerchandiseNotAsDescribed MerchandiseNotAsDescribed { get; set; }

        [JsonProperty("no_valid_authorization")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("no_valid_authorization")]
#endif
        public DisputeEvidenceNoValidAuthorization NoValidAuthorization { get; set; }

        [JsonProperty("not_received")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("not_received")]
#endif
        public DisputeEvidenceNotReceived NotReceived { get; set; }

        [JsonProperty("other")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("other")]
#endif
        public DisputeEvidenceOther Other { get; set; }

        /// <summary>
        /// The reason for filing the dispute. Its value will match the field containing the
        /// evidence.
        /// One of: <c>canceled</c>, <c>duplicate</c>, <c>fraudulent</c>,
        /// <c>merchandise_not_as_described</c>, <c>no_valid_authorization</c>, <c>not_received</c>,
        /// <c>other</c>, or <c>service_not_as_described</c>.
        /// </summary>
        [JsonProperty("reason")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("reason")]
#endif
        public string Reason { get; set; }

        [JsonProperty("service_not_as_described")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("service_not_as_described")]
#endif
        public DisputeEvidenceServiceNotAsDescribed ServiceNotAsDescribed { get; set; }
    }
}
