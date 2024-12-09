// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class DisputeEvidenceEnhancedEvidenceVisaComplianceOptions : INestedOptions
    {
        /// <summary>
        /// A field acknowledging the fee incurred when countering a Visa Compliance dispute. If
        /// this field is set to true, evidence can be submitted for the compliance dispute, and you
        /// may incur a $500 fee if the case is lost.
        /// </summary>
        [JsonProperty("fee_acknowledged")]
        public bool? FeeAcknowledged { get; set; }
    }
}
