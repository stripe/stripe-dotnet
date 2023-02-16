// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class SessionCustomFieldDropdownOptions : INestedOptions
    {
        /// <summary>
        /// The options available for the customer to select. Up to 200 options allowed.
        /// </summary>
        [JsonProperty("options")]
        public List<SessionCustomFieldDropdownOptionOptions> Options { get; set; }
    }
}
