// File generated from our OpenAPI spec
namespace Stripe.FinancialConnections
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AuthorizationStatusDetailsInactive : StripeEntity<AuthorizationStatusDetailsInactive>
    {
        /// <summary>
        /// The action (if any) to relink the inactive Authorization.
        /// One of: <c>none</c>, or <c>relink_required</c>.
        /// </summary>
        [JsonProperty("action")]
        [STJS.JsonPropertyName("action")]
        public string Action { get; set; }
    }
}
