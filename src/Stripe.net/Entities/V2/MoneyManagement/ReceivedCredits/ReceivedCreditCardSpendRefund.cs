// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ReceivedCreditCardSpendRefund : StripeEntity<ReceivedCreditCardSpendRefund>
    {
        /// <summary>
        /// The reference to the v1 issuing transaction ID.
        /// </summary>
        [JsonProperty("issuing_transaction_v1")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("issuing_transaction_v1")]
#endif
        public string IssuingTransactionV1 { get; set; }
    }
}
