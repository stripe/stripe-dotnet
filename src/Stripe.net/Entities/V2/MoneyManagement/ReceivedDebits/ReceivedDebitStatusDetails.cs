// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ReceivedDebitStatusDetails : StripeEntity<ReceivedDebitStatusDetails>
    {
        /// <summary>
        /// Information that elaborates on the <c>failed</c> status of a ReceivedDebit. It is only
        /// present when the ReceivedDebit status is <c>failed</c>.
        /// </summary>
        [JsonProperty("failed")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("failed")]
#endif
        public ReceivedDebitStatusDetailsFailed Failed { get; set; }
    }
}
