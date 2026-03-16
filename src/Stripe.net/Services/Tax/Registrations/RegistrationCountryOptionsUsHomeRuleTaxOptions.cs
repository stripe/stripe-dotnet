// File generated from our OpenAPI spec
namespace Stripe.Tax
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class RegistrationCountryOptionsUsHomeRuleTaxOptions : INestedOptions
    {
        /// <summary>
        /// A jurisdiction code representing the <a
        /// href="https://stripe.com/tax/registering?type=home_rule_tax#registration-types">local
        /// jurisdiction</a>.
        /// </summary>
        [JsonProperty("jurisdiction")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("jurisdiction")]
#endif
        public string Jurisdiction { get; set; }
    }
}
