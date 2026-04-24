// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class ApprovalRequestSubmitOptions : BaseOptions
    {
        /// <summary>
        /// The reason for submitting the approval request.
        /// </summary>
        [JsonProperty("reason")]
        [STJS.JsonPropertyName("reason")]
        public string Reason { get; set; }
    }
}
