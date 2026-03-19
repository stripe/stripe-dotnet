// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class SourceRedirectOptions : INestedOptions
    {
        /// <summary>
        /// The URL you provide to redirect the customer back to you after they authenticated their
        /// payment. It can use your application URI scheme in the context of a mobile application.
        /// </summary>
        [JsonProperty("return_url")]
        [STJS.JsonPropertyName("return_url")]
        public string ReturnUrl { get; set; }
    }
}
