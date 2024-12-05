// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentIntentGetOptions : BaseOptions
    {
        /// <summary>
        /// The client secret of the PaymentIntent. We require it if you use a publishable key to
        /// retrieve the source.
        /// </summary>
        [JsonProperty("client_secret")]
        public string ClientSecret { get; set; }
    }
}
