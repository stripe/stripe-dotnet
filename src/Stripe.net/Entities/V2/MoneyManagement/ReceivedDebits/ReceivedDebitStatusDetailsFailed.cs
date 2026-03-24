// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ReceivedDebitStatusDetailsFailed : StripeEntity<ReceivedDebitStatusDetailsFailed>
    {
        /// <summary>
        /// Open Enum. The reason for the failure of the ReceivedDebit.
        /// One of: <c>financial_address_inactive</c>, <c>insufficient_funds</c>, or
        /// <c>stripe_rejected</c>.
        /// </summary>
        [JsonProperty("reason")]
        [STJS.JsonPropertyName("reason")]
        public string Reason { get; set; }
    }
}
