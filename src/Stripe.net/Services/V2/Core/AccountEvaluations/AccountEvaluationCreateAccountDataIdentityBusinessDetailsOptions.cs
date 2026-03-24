// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AccountEvaluationCreateAccountDataIdentityBusinessDetailsOptions : INestedOptions
    {
        /// <summary>
        /// Registered business name.
        /// </summary>
        [JsonProperty("registered_name")]
        [STJS.JsonPropertyName("registered_name")]
        public string RegisteredName { get; set; }
    }
}
