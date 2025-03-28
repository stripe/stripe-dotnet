// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    /// <summary>
    /// The PayoutMethodsBankAccountSpec object.
    /// </summary>
    public class PayoutMethodsBankAccountSpec : StripeEntity<PayoutMethodsBankAccountSpec>, IHasObject
    {
        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value of
        /// the object field.
        /// </summary>
        [JsonProperty("object")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("object")]
#endif
        public string Object { get; set; }

        /// <summary>
        /// The list of specs by country.
        /// </summary>
        [JsonProperty("countries")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("countries")]
#endif
        public Dictionary<string, PayoutMethodsBankAccountSpecCountries> Countries { get; set; }
    }
}
