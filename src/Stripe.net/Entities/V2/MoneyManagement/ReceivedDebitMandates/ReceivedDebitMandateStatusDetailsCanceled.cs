// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ReceivedDebitMandateStatusDetailsCanceled : StripeEntity<ReceivedDebitMandateStatusDetailsCanceled>
    {
        /// <summary>
        /// The <c>canceled</c> status reason.
        /// One of: <c>canceled_by_beneficiary</c>, <c>canceled_by_stripe</c>, or
        /// <c>user_action</c>.
        /// </summary>
        [JsonProperty("reason")]
        [STJS.JsonPropertyName("reason")]
        public string Reason { get; set; }
    }
}
