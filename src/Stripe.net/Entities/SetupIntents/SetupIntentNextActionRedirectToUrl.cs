// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class SetupIntentNextActionRedirectToUrl : StripeEntity<SetupIntentNextActionRedirectToUrl>
    {
        /// <summary>
        /// If the customer does not exit their browser while authenticating, they will be
        /// redirected to this specified URL after completion.
        /// </summary>
        [JsonProperty("return_url")]
        [STJS.JsonPropertyName("return_url")]
        public string ReturnUrl { get; set; }

        /// <summary>
        /// The URL you must redirect your customer to in order to authenticate.
        /// </summary>
        [JsonProperty("url")]
        [STJS.JsonPropertyName("url")]
        public string Url { get; set; }
    }
}
