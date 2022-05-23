// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class SetupIntentPaymentMethodOptionsLinkOptions : INestedOptions
    {
        /// <summary>
        /// Token used for persistent Link logins.
        /// </summary>
        [JsonProperty("persistent_token")]
        public string PersistentToken { get; set; }
    }
}
