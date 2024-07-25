// File generated from our OpenAPI spec
namespace Stripe.Tax
{
    using Newtonsoft.Json;

    public class AssociationStatusDetailsErrored : StripeEntity<AssociationStatusDetailsErrored>
    {
        /// <summary>
        /// Details on why we could not commit the Tax Transaction.
        /// One of: <c>another_payment_associated_with_calculation</c>, <c>calculation_expired</c>,
        /// <c>currency_mismatch</c>, or <c>unique_reference_violation</c>.
        /// </summary>
        [JsonProperty("reason")]
        public string Reason { get; set; }
    }
}
