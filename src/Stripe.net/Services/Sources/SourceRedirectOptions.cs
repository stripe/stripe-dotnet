namespace Stripe
{
    using Newtonsoft.Json;

    public class SourceRedirectOptions : INestedOptions
    {
        /// <summary>
        /// The URL you provide to redirect the customer back to you after they authenticated their
        /// payment. It can use your application URI scheme in the context of a mobile application.
        /// </summary>
        [JsonProperty("return_url")]
        public string ReturnUrl { get; set; }
    }
}
