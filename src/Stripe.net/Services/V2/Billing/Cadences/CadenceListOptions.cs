// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class CadenceListOptions : V2.ListOptions
    {
        /// <summary>
        /// Additional resource to include in the response.
        /// </summary>
        [JsonProperty("include")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("include")]
#endif
        public List<string> Include { get; set; }

        /// <summary>
        /// If provided, only Cadences that specifically reference the payer will be returned.
        /// Mutually exclusive with <c>test_clock</c>.
        /// </summary>
        [JsonProperty("payer")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("payer")]
#endif
        public CadenceListPayerOptions Payer { get; set; }

        /// <summary>
        /// If provided, only Cadences that specifically reference the provided test clock ID (via
        /// the customer's test clock) will be returned. Mutually exclusive with <c>payer</c>.
        /// </summary>
        [JsonProperty("test_clock")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("test_clock")]
#endif
        public string TestClock { get; set; }
    }
}
