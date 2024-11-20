// File generated from our OpenAPI spec
namespace Stripe.TestHelpers.Issuing
{
    using Newtonsoft.Json;

    public class AuthorizationRespondOptions : BaseOptions
    {
        /// <summary>
        /// Whether to simulate the user confirming that the transaction was legitimate (true) or
        /// telling Stripe that it was fraudulent (false).
        /// </summary>
        [JsonProperty("confirmed")]
        public bool? Confirmed { get; set; }
    }
}
