// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using Newtonsoft.Json;

    public class DisputeEvidence : StripeEntity<DisputeEvidence>
    {
        [JsonProperty("canceled")]
        public DisputeEvidenceCanceled Canceled { get; set; }

        [JsonProperty("duplicate")]
        public DisputeEvidenceDuplicate Duplicate { get; set; }

        [JsonProperty("fraudulent")]
        public DisputeEvidenceFraudulent Fraudulent { get; set; }

        [JsonProperty("merchandise_not_as_described")]
        public DisputeEvidenceMerchandiseNotAsDescribed MerchandiseNotAsDescribed { get; set; }

        [JsonProperty("not_received")]
        public DisputeEvidenceNotReceived NotReceived { get; set; }

        [JsonProperty("other")]
        public DisputeEvidenceOther Other { get; set; }

        /// <summary>
        /// The reason for filing the dispute. Its value will match the field containing the
        /// evidence.
        /// One of: <c>canceled</c>, <c>duplicate</c>, <c>fraudulent</c>,
        /// <c>merchandise_not_as_described</c>, <c>not_received</c>, <c>other</c>, or
        /// <c>service_not_as_described</c>.
        /// </summary>
        [JsonProperty("reason")]
        public string Reason { get; set; }

        [JsonProperty("service_not_as_described")]
        public DisputeEvidenceServiceNotAsDescribed ServiceNotAsDescribed { get; set; }
    }
}
