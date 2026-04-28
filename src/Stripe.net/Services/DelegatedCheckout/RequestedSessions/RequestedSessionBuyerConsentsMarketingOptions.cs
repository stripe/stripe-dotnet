// File generated from our OpenAPI spec
namespace Stripe.DelegatedCheckout
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class RequestedSessionBuyerConsentsMarketingOptions : INestedOptions
    {
        /// <summary>
        /// The list of marketing consent entries.
        /// </summary>
        [JsonProperty("consents")]
        [STJS.JsonPropertyName("consents")]
        public List<RequestedSessionBuyerConsentsMarketingConsentOptions> Consents { get; set; }
    }
}
