// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class PaymentLinkCustomFieldDropdownOptions : INestedOptions
    {
        /// <summary>
        /// The value that pre-fills the field on the payment page.Must match a <c>value</c> in the
        /// <c>options</c> array.
        /// </summary>
        [JsonProperty("default_value")]
        [STJS.JsonPropertyName("default_value")]
        public string DefaultValue { get; set; }

        /// <summary>
        /// The options available for the customer to select. Up to 200 options allowed.
        /// </summary>
        [JsonProperty("options")]
        [STJS.JsonPropertyName("options")]
        public List<PaymentLinkCustomFieldDropdownOptionOptions> Options { get; set; }
    }
}
