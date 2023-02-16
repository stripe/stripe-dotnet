// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentLinkCustomField : StripeEntity<PaymentLinkCustomField>
    {
        /// <summary>
        /// Configuration for <c>type=dropdown</c> fields.
        /// </summary>
        [JsonProperty("dropdown")]
        public PaymentLinkCustomFieldDropdown Dropdown { get; set; }

        /// <summary>
        /// String of your choice that your integration can use to reconcile this field. Must be
        /// unique to this field, alphanumeric, and up to 200 characters.
        /// </summary>
        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("label")]
        public PaymentLinkCustomFieldLabel Label { get; set; }

        /// <summary>
        /// Whether the customer is required to complete the field before completing the Checkout
        /// Session. Defaults to <c>false</c>.
        /// </summary>
        [JsonProperty("optional")]
        public bool Optional { get; set; }

        /// <summary>
        /// The type of the field.
        /// One of: <c>dropdown</c>, <c>numeric</c>, or <c>text</c>.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
