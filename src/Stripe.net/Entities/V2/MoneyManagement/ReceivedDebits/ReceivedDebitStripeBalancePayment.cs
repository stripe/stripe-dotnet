// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ReceivedDebitStripeBalancePayment : StripeEntity<ReceivedDebitStripeBalancePayment>
    {
        /// <summary>
        /// ID of the debit agreement associated with this payment.
        /// </summary>
        [JsonProperty("debit_agreement")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("debit_agreement")]
#endif
        public string DebitAgreement { get; set; }

        /// <summary>
        /// Statement descriptor for the Stripe Balance Payment.
        /// </summary>
        [JsonProperty("statement_descriptor")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("statement_descriptor")]
#endif
        public string StatementDescriptor { get; set; }
    }
}
