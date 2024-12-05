// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class TokenCvcUpdateOptions : INestedOptions
    {
        /// <summary>
        /// The CVC value, in string form.
        /// </summary>
        [JsonProperty("cvc")]
        public string Cvc { get; set; }
    }
}
