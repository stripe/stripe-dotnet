namespace Stripe
{
#if USE_SYSTEM_TEXT_JSON
    using System.Text.Json.Serialization;
#else
    using Newtonsoft.Json;
#endif

    public class AccountControllerStripeDashboard : StripeEntity<AccountControllerStripeDashboard>
    {
        /// <summary>
        /// A value indicating the Stripe dashboard this account has access to independent of the
        /// Connect application.
        /// One of: <c>express</c>, <c>full</c>, or <c>none</c>.
        /// </summary>
#if USE_SYSTEM_TEXT_JSON
        [JsonPropertyName("type")]
#else
        [JsonProperty("type")]
#endif
        public string Type { get; set; }
    }
}
