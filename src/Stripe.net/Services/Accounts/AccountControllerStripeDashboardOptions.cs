// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountControllerStripeDashboardOptions : INestedOptions
    {
        /// <summary>
        /// Whether this account should have access to the full Stripe Dashboard (<c>full</c>), to
        /// the Express Dashboard (<c>express</c>), or to no Stripe-hosted dashboard (<c>none</c>).
        /// Defaults to <c>full</c>.
        /// One of: <c>express</c>, <c>full</c>, or <c>none</c>.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }
    }
}
