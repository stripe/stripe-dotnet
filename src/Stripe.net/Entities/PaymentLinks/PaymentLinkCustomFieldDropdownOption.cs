// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentLinkCustomFieldDropdownOption : StripeEntity<PaymentLinkCustomFieldDropdownOption>
    {
        /// <summary>
        /// The label for the option, displayed to the customer. Up to 100 characters.
        /// </summary>
        [JsonProperty("label")]
        public string Label { get; set; }

        /// <summary>
        /// The value for this option, not displayed to the customer, used by your integration to
        /// reconcile the option selected by the customer. Must be unique to this option,
        /// alphanumeric, and up to 100 characters.
        /// </summary>
        [JsonProperty("value")]
        public string Value { get; set; }
    }
}
