// File generated from our OpenAPI spec
namespace Stripe.V2.Iam
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ActivityLogDetailsSso : StripeEntity<ActivityLogDetailsSso>
    {
        /// <summary>
        /// SSO enforcement level.
        /// One of: <c>off</c>, <c>optional</c>, or <c>required</c>.
        /// </summary>
        [JsonProperty("mandate")]
        [STJS.JsonPropertyName("mandate")]
        public string Mandate { get; set; }
    }
}
