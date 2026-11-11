// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class ReceivedDebitListOptions : V2.ListOptions
    {
        /// <summary>
        /// Filter by the received debit mandate ID. Deprecated: use <c>spending_mandate</c>
        /// instead.
        /// </summary>
        [JsonProperty("received_debit_mandate")]
        [STJS.JsonPropertyName("received_debit_mandate")]
        public string ReceivedDebitMandate { get; set; }

        /// <summary>
        /// Filter by the SpendingMandate ID.
        /// </summary>
        [JsonProperty("spending_mandate")]
        [STJS.JsonPropertyName("spending_mandate")]
        public string SpendingMandate { get; set; }
    }
}
