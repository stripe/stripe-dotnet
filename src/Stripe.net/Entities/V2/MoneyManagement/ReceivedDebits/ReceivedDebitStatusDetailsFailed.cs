// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ReceivedDebitStatusDetailsFailed : StripeEntity<ReceivedDebitStatusDetailsFailed>
    {
        /// <summary>
        /// Open Enum. The reason for the failure of the ReceivedDebit.
        /// One of: <c>financial_address_inactive</c>, <c>insufficient_funds</c>, or
        /// <c>stripe_rejected</c>.
        /// </summary>
        [JsonProperty("reason")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("reason")]
#endif
        public string Reason { get; set; }
    }
}
