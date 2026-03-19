// File generated from our OpenAPI spec
namespace Stripe.V2.Core.Accounts
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class PersonTokenCreateAdditionalTermsOfServiceOptions : INestedOptions
    {
        /// <summary>
        /// Details on the Person's acceptance of the [Stripe Services Agreement]; IP, date, and
        /// User Agent are expanded by Stripe.
        /// </summary>
        [JsonProperty("account")]
        [STJS.JsonPropertyName("account")]
        public PersonTokenCreateAdditionalTermsOfServiceAccountOptions Account { get; set; }
    }
}
