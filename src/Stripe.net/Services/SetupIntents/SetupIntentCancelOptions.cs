// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class SetupIntentCancelOptions : BaseOptions
    {
        /// <summary>
        /// Reason for canceling this SetupIntent. Possible values are: <c>abandoned</c>,
        /// <c>requested_by_customer</c>, or <c>duplicate</c>.
        /// One of: <c>abandoned</c>, <c>duplicate</c>, or <c>requested_by_customer</c>.
        /// </summary>
        [JsonProperty("cancellation_reason")]
        [STJS.JsonPropertyName("cancellation_reason")]
        public string CancellationReason { get; set; }
    }
}
