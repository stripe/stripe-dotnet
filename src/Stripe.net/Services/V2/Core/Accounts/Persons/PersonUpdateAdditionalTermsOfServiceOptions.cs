// File generated from our OpenAPI spec
namespace Stripe.V2.Core.Accounts
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class PersonUpdateAdditionalTermsOfServiceOptions : INestedOptions
    {
        /// <summary>
        /// Stripe terms of service agreement.
        /// </summary>
        [JsonProperty("account")]
        [STJS.JsonPropertyName("account")]
        public PersonUpdateAdditionalTermsOfServiceAccountOptions Account { get; set; }
    }
}
