// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ApprovalRequestStatusDetailsSucceeded : StripeEntity<ApprovalRequestStatusDetailsSucceeded>
    {
        /// <summary>
        /// The result of the successful execution.
        /// </summary>
        [JsonProperty("result")]
        [STJS.JsonPropertyName("result")]
        public ApprovalRequestStatusDetailsSucceededResult Result { get; set; }
    }
}
