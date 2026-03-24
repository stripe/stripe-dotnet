// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class CadenceListOptions : V2.ListOptions
    {
        /// <summary>
        /// Additional resource to include in the response.
        /// One of: <c>invoice_discount_rules</c>, or <c>settings_data</c>.
        /// </summary>
        [JsonProperty("include")]
        [STJS.JsonPropertyName("include")]
        public List<string> Include { get; set; }

        /// <summary>
        /// Only return the cadences with these lookup_keys, if any exist. You can specify up to 10
        /// lookup_keys. Mutually exclusive with <c>test_clock</c> and <c>payer</c>.
        /// </summary>
        [JsonProperty("lookup_keys")]
        [STJS.JsonPropertyName("lookup_keys")]
        public List<string> LookupKeys { get; set; }

        /// <summary>
        /// If provided, only cadences that specifically reference the payer will be returned.
        /// Mutually exclusive with <c>test_clock</c> and <c>lookup_keys</c>.
        /// </summary>
        [JsonProperty("payer")]
        [STJS.JsonPropertyName("payer")]
        public CadenceListPayerOptions Payer { get; set; }

        /// <summary>
        /// If provided, only cadences that specifically reference the provided test clock ID (via
        /// the customer's test clock) will be returned. Mutually exclusive with <c>payer</c>.
        /// </summary>
        [JsonProperty("test_clock")]
        [STJS.JsonPropertyName("test_clock")]
        public string TestClock { get; set; }
    }
}
