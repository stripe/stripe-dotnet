// File generated from our OpenAPI spec
namespace Stripe.DelegatedCheckout
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class RequestedSessionBuyerConsentsMarketing : StripeEntity<RequestedSessionBuyerConsentsMarketing>
    {
        /// <summary>
        /// The available marketing consent options.
        /// </summary>
        [JsonProperty("options")]
        [STJS.JsonPropertyName("options")]
        public List<RequestedSessionBuyerConsentsMarketingOption> Options { get; set; }
    }
}
