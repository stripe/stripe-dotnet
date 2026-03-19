// File generated from our OpenAPI spec
namespace Stripe.Identity
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class VerificationSessionRelatedPersonOptions : INestedOptions
    {
        /// <summary>
        /// A token representing a connected account. If provided, the person parameter is also
        /// required and must be associated with the account.
        /// </summary>
        [JsonProperty("account")]
        [STJS.JsonPropertyName("account")]
        public string Account { get; set; }

        /// <summary>
        /// A token referencing a Person resource that this verification is being used to verify.
        /// </summary>
        [JsonProperty("person")]
        [STJS.JsonPropertyName("person")]
        public string Person { get; set; }
    }
}
