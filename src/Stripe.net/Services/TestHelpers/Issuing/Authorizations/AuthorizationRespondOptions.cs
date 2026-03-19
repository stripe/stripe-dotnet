// File generated from our OpenAPI spec
namespace Stripe.TestHelpers.Issuing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AuthorizationRespondOptions : BaseOptions
    {
        /// <summary>
        /// Whether to simulate the user confirming that the transaction was legitimate (true) or
        /// telling Stripe that it was fraudulent (false).
        /// </summary>
        [JsonProperty("confirmed")]
        [STJS.JsonPropertyName("confirmed")]
        public bool? Confirmed { get; set; }
    }
}
