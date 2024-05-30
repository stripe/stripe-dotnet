// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class SessionCustomFieldDropdownOptions : INestedOptions
    {
        /// <summary>
        /// The value that will pre-fill the field on the payment page.Must match a <c>value</c> in
        /// the <c>options</c> array.
        /// </summary>
        [JsonProperty("default_value")]
        public string DefaultValue { get; set; }

        /// <summary>
        /// The options available for the customer to select. Up to 200 options allowed.
        /// </summary>
        [JsonProperty("options")]
        public List<SessionCustomFieldDropdownOptionOptions> Options { get; set; }
    }
}
