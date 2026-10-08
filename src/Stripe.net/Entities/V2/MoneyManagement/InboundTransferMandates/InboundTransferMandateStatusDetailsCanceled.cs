// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class InboundTransferMandateStatusDetailsCanceled : StripeEntity<InboundTransferMandateStatusDetailsCanceled>
    {
        /// <summary>
        /// The reason the mandate was canceled.
        /// One of: <c>canceled_by_network</c>, <c>canceled_by_user</c>, <c>refused_by_network</c>,
        /// or <c>revoked_by_stripe</c>.
        /// </summary>
        [JsonProperty("reason")]
        [STJS.JsonPropertyName("reason")]
        public string Reason { get; set; }
    }
}
