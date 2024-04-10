// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class AccountControllerStripeDashboard : StripeEntity<AccountControllerStripeDashboard>
    {
        /// <summary>
        /// A value indicating the Stripe dashboard this account has access to independent of the
        /// Connect application.
        /// One of: <c>express</c>, <c>full</c>, or <c>none</c>.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
