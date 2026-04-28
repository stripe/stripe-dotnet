// File generated from our OpenAPI spec
namespace Stripe.DelegatedCheckout
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class RequestedSessionBuyerConsentsOptions : INestedOptions
    {
        /// <summary>
        /// The marketing consent data for the buyer.
        /// </summary>
        [JsonProperty("marketing")]
        [STJS.JsonPropertyName("marketing")]
        public RequestedSessionBuyerConsentsMarketingOptions Marketing { get; set; }
    }
}
