// File generated from our OpenAPI spec
namespace Stripe.Tax
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AssociationTaxTransactionAttemptErrored : StripeEntity<AssociationTaxTransactionAttemptErrored>
    {
        /// <summary>
        /// Details on why we couldn't commit the tax transaction.
        /// One of: <c>another_payment_associated_with_calculation</c>, <c>calculation_expired</c>,
        /// <c>currency_mismatch</c>, <c>original_transaction_voided</c>, or
        /// <c>unique_reference_violation</c>.
        /// </summary>
        [JsonProperty("reason")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("reason")]
#endif
        public string Reason { get; set; }
    }
}
