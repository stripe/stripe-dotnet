namespace Stripe
{
    using Newtonsoft.Json;

    public class SetupIntentGetOptions : BaseOptions
    {
        /// <summary>
        /// The client secret of the SetupIntent. Required if a publishable key is used to
        /// retrieve the setup intent.
        /// </summary>
        [JsonProperty("client_secret")]
        public string ClientSecret { get; set; }
    }
}
