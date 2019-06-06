namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentIntentGetOptions : BaseOptions
    {
        /// <summary>
        /// The client secret of the PaymentIntent. Required if a publishable key is used to
        /// retrieve the payment intent.
        /// </summary>
        [JsonProperty("client_secret")]
        public string ClientSecret { get; set; }
    }
}
