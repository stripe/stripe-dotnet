// File generated from our OpenAPI spec
namespace Stripe.Tax
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class RegistrationCountryOptionsCh : StripeEntity<RegistrationCountryOptionsCh>
    {
        [JsonProperty("standard")]
        [STJS.JsonPropertyName("standard")]
        public RegistrationCountryOptionsChStandard Standard { get; set; }

        /// <summary>
        /// Type of registration in <c>country</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
