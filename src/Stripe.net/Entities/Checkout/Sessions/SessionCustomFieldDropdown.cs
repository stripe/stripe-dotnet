// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class SessionCustomFieldDropdown : StripeEntity<SessionCustomFieldDropdown>
    {
        /// <summary>
        /// The options available for the customer to select. Up to 200 options allowed.
        /// </summary>
        [JsonProperty("options")]
        public List<SessionCustomFieldDropdownOption> Options { get; set; }

        /// <summary>
        /// The option selected by the customer. This will be the <c>value</c> for the option.
        /// </summary>
        [JsonProperty("value")]
        public string Value { get; set; }
    }
}
