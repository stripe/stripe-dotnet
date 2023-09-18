// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentIntentGetOptions : BaseOptions
    {
        /// <summary>
        /// The client secret of the PaymentIntent. It's required if you use a publishable key to
        /// retrieve the source.
        /// </summary>
        [JsonProperty("client_secret")]
        public string ClientSecret { get; set; }
    }
}
