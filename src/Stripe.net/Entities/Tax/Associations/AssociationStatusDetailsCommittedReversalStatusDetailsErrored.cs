// File generated from our OpenAPI spec
namespace Stripe.Tax
{
    using Newtonsoft.Json;

    public class AssociationStatusDetailsCommittedReversalStatusDetailsErrored : StripeEntity<AssociationStatusDetailsCommittedReversalStatusDetailsErrored>
    {
        /// <summary>
        /// Details on why we could not commit the reversal Tax Transaction.
        /// One of: <c>original_transaction_voided</c>, or <c>unique_reference_violation</c>.
        /// </summary>
        [JsonProperty("reason")]
        public string Reason { get; set; }

        /// <summary>
        /// The <a href="https://stripe.com/docs/api/refunds/object">Refund</a> ID that should have
        /// created a tax reversal.
        /// </summary>
        [JsonProperty("refund_id")]
        public string RefundId { get; set; }
    }
}
