// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentLinkCustomFieldDropdownOptions : INestedOptions
    {
        /// <summary>
        /// The options available for the customer to select. Up to 200 options allowed.
        /// </summary>
        [JsonProperty("options")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("options")]
#endif
        public List<PaymentLinkCustomFieldDropdownOptionOptions> Options { get; set; }
    }
}
