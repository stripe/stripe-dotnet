// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class DebitDisputeStatusDetails : StripeEntity<DebitDisputeStatusDetails>
    {
        /// <summary>
        /// Information that elaborates on the <c>failed</c> status of a DebitDispute. It is only
        /// present when the DebitDispute status is <c>failed</c>.
        /// </summary>
        [JsonProperty("failed")]
        [STJS.JsonPropertyName("failed")]
        public DebitDisputeStatusDetailsFailed Failed { get; set; }
    }
}
