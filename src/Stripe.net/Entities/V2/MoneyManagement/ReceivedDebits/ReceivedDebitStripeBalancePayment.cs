// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ReceivedDebitStripeBalancePayment : StripeEntity<ReceivedDebitStripeBalancePayment>
    {
        /// <summary>
        /// ID of the debit agreement associated with this payment.
        /// </summary>
        [JsonProperty("debit_agreement")]
        [STJS.JsonPropertyName("debit_agreement")]
        public string DebitAgreement { get; set; }

        /// <summary>
        /// Statement descriptor for the Stripe Balance Payment.
        /// </summary>
        [JsonProperty("statement_descriptor")]
        [STJS.JsonPropertyName("statement_descriptor")]
        public string StatementDescriptor { get; set; }
    }
}
