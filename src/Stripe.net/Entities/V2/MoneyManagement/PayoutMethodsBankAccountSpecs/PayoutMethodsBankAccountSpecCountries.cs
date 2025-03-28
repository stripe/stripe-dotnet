// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PayoutMethodsBankAccountSpecCountries : StripeEntity<PayoutMethodsBankAccountSpecCountries>
    {
        /// <summary>
        /// The list of fields for a country, along with associated information.
        /// </summary>
        [JsonProperty("fields")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("fields")]
#endif
        public List<PayoutMethodsBankAccountSpecCountriesField> Fields { get; set; }
    }
}
