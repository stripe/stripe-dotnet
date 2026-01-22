// File generated from our OpenAPI spec
namespace Stripe.FinancialConnections
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AuthorizationStatusDetailsInactive : StripeEntity<AuthorizationStatusDetailsInactive>
    {
        /// <summary>
        /// The action (if any) to relink the inactive Authorization.
        /// One of: <c>none</c>, or <c>relink_required</c>.
        /// </summary>
        [JsonProperty("action")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("action")]
#endif
        public string Action { get; set; }
    }
}
