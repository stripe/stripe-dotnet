// File generated from our OpenAPI spec
namespace Stripe.Events
{
    using System.Threading.Tasks;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    public class V2IamStripeAccessGrantDeniedEventData : StripeEntity<V2IamStripeAccessGrantDeniedEventData>
    {
        /// <summary>
        /// ID of denied Stripe Access Grant.
        /// </summary>
        [JsonProperty("stripe_access_grant")]
        [STJS.JsonPropertyName("stripe_access_grant")]
        public string StripeAccessGrant { get; set; }
    }
}
