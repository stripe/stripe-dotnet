// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PayoutMethodsBankAccountSpecCountries : StripeEntity<PayoutMethodsBankAccountSpecCountries>
    {
        /// <summary>
        /// The list of fields for a country, along with associated information.
        /// </summary>
        [JsonProperty("fields")]
        [STJS.JsonPropertyName("fields")]
        public List<PayoutMethodsBankAccountSpecCountriesField> Fields { get; set; }
    }
}
