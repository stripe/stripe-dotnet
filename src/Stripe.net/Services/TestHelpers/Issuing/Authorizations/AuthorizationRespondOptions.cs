// File generated from our OpenAPI spec
namespace Stripe.TestHelpers.Issuing
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AuthorizationRespondOptions : BaseOptions
    {
        /// <summary>
        /// Whether to simulate the user confirming that the transaction was legitimate (true) or
        /// telling Stripe that it was fraudulent (false).
        /// </summary>
        [JsonProperty("confirmed")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("confirmed")]
#endif
        public bool? Confirmed { get; set; }
    }
}
