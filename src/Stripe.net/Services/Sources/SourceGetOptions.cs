namespace Stripe
{
    using Newtonsoft.Json;

    public class SourceGetOptions : BaseOptions
    {
        /// <summary>
        /// The client secret of the source. Required if a publishable key is used to retrieve the
        /// source.
        /// </summary>
        [JsonProperty("client_secret")]
        public string ClientSecret { get; set; }
    }
}
