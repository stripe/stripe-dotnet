// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class PaymentLinkCustomFieldDropdownOptions : INestedOptions
    {
        /// <summary>
        /// The options available for the customer to select. Up to 200 options allowed.
        /// </summary>
        [JsonProperty("options")]
        public List<PaymentLinkCustomFieldDropdownOptionOptions> Options { get; set; }
    }
}
