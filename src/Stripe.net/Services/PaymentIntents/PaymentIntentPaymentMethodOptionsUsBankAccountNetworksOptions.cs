// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentIntentPaymentMethodOptionsUsBankAccountNetworksOptions : INestedOptions
    {
        /// <summary>
        /// Triggers validations to run across the selected networks.
        /// One of: <c>ach</c>, or <c>us_domestic_wire</c>.
        /// </summary>
        [JsonProperty("requested")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("requested")]
#endif
        public List<string> Requested { get; set; }
    }
}
