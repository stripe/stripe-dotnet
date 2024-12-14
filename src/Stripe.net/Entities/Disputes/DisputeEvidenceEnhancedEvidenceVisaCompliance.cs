// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class DisputeEvidenceEnhancedEvidenceVisaCompliance : StripeEntity<DisputeEvidenceEnhancedEvidenceVisaCompliance>
    {
        /// <summary>
        /// A field acknowledging the fee incurred when countering a Visa compliance dispute. If
        /// this field is set to true, evidence can be submitted for the compliance dispute. Stripe
        /// collects a 500 USD (or local equivalent) amount to cover the network costs associated
        /// with resolving compliance disputes. Stripe refunds the 500 USD network fee if you win
        /// the dispute.
        /// </summary>
        [JsonProperty("fee_acknowledged")]
        public bool FeeAcknowledged { get; set; }
    }
}
