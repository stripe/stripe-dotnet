// File generated from our OpenAPI spec
namespace Stripe.DelegatedCheckout
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class RequestedSessionBuyerConsents : StripeEntity<RequestedSessionBuyerConsents>
    {
        /// <summary>
        /// The marketing consent options.
        /// </summary>
        [JsonProperty("marketing")]
        [STJS.JsonPropertyName("marketing")]
        public RequestedSessionBuyerConsentsMarketing Marketing { get; set; }
    }
}
