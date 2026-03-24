// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class SourceGetOptions : BaseOptions
    {
        /// <summary>
        /// The client secret of the source. Required if a publishable key is used to retrieve the
        /// source.
        /// </summary>
        [JsonProperty("client_secret")]
        [STJS.JsonPropertyName("client_secret")]
        public string ClientSecret { get; set; }
    }
}
