// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentIntentGetOptions : BaseOptions
    {
        /// <summary>
        /// The client secret of the PaymentIntent. We require it if you use a publishable key to
        /// retrieve the source.
        /// </summary>
        [JsonProperty("client_secret")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("client_secret")]
#endif

        public string ClientSecret { get; set; }
    }
}
