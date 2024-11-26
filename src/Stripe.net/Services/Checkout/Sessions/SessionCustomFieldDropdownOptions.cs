// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class SessionCustomFieldDropdownOptions : INestedOptions
    {
        /// <summary>
        /// The value that will pre-fill the field on the payment page.Must match a <c>value</c> in
        /// the <c>options</c> array.
        /// </summary>
        [JsonProperty("default_value")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("default_value")]
#endif
        public string DefaultValue { get; set; }

        /// <summary>
        /// The options available for the customer to select. Up to 200 options allowed.
        /// </summary>
        [JsonProperty("options")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("options")]
#endif
        public List<SessionCustomFieldDropdownOptionOptions> Options { get; set; }
    }
}
