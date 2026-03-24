// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AccountEvaluationCreateAccountDataIdentityOptions : INestedOptions
    {
        /// <summary>
        /// Business details for identity data.
        /// </summary>
        [JsonProperty("business_details")]
        [STJS.JsonPropertyName("business_details")]
        public AccountEvaluationCreateAccountDataIdentityBusinessDetailsOptions BusinessDetails { get; set; }
    }
}
