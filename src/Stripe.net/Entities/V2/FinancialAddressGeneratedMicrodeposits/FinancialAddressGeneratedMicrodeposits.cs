// File generated from our OpenAPI spec
namespace Stripe.V2
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class FinancialAddressGeneratedMicrodeposits : StripeEntity<FinancialAddressGeneratedMicrodeposits>, IHasObject
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
        /// The amounts of the microdeposits that were generated.
        /// </summary>
        [JsonProperty("amounts")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amounts")]
#endif
        public List<Amount> Amounts { get; set; }

        /// <summary>
        /// Closed Enum. The status of the request.
        /// </summary>
        [JsonProperty("status")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("status")]
#endif
        public string Status { get; set; }
    }
}
