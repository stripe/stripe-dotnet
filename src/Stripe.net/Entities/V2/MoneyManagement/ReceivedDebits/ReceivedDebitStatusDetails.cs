// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ReceivedDebitStatusDetails : StripeEntity<ReceivedDebitStatusDetails>
    {
        /// <summary>
        /// Information that elaborates on the <c>failed</c> status of a ReceivedDebit. It is only
        /// present when the ReceivedDebit status is <c>failed</c>.
        /// </summary>
        [JsonProperty("failed")]
        [STJS.JsonPropertyName("failed")]
        public ReceivedDebitStatusDetailsFailed Failed { get; set; }
    }
}
