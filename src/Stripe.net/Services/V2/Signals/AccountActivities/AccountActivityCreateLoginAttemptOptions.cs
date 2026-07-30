// File generated from our OpenAPI spec
namespace Stripe.V2.Signals
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AccountActivityCreateLoginAttemptOptions : INestedOptions
    {
        /// <summary>
        /// Client details captured for the attempt.
        /// </summary>
        [JsonProperty("client_details")]
        [STJS.JsonPropertyName("client_details")]
        public AccountActivityCreateLoginAttemptClientDetailsOptions ClientDetails { get; set; }
    }
}
