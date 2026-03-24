// File generated from our OpenAPI spec
namespace Stripe.Tax
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class RegistrationCountryOptionsUsHomeRuleTaxOptions : INestedOptions
    {
        /// <summary>
        /// A jurisdiction code representing the <a
        /// href="https://stripe.com/tax/registering?type=home_rule_tax#registration-types">local
        /// jurisdiction</a>.
        /// </summary>
        [JsonProperty("jurisdiction")]
        [STJS.JsonPropertyName("jurisdiction")]
        public string Jurisdiction { get; set; }
    }
}
