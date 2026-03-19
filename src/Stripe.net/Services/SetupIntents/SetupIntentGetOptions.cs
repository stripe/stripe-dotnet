// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class SetupIntentGetOptions : BaseOptions
    {
        /// <summary>
        /// The client secret of the SetupIntent. We require this string if you use a publishable
        /// key to retrieve the SetupIntent.
        /// </summary>
        [JsonProperty("client_secret")]
        [STJS.JsonPropertyName("client_secret")]
        public string ClientSecret { get; set; }
    }
}
