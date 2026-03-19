// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PaymentLinkCustomField : StripeEntity<PaymentLinkCustomField>
    {
        [JsonProperty("dropdown")]
        [STJS.JsonPropertyName("dropdown")]
        public PaymentLinkCustomFieldDropdown Dropdown { get; set; }

        /// <summary>
        /// String of your choice that your integration can use to reconcile this field. Must be
        /// unique to this field, alphanumeric, and up to 200 characters.
        /// </summary>
        [JsonProperty("key")]
        [STJS.JsonPropertyName("key")]
        public string Key { get; set; }

        [JsonProperty("label")]
        [STJS.JsonPropertyName("label")]
        public PaymentLinkCustomFieldLabel Label { get; set; }

        [JsonProperty("numeric")]
        [STJS.JsonPropertyName("numeric")]
        public PaymentLinkCustomFieldNumeric Numeric { get; set; }

        /// <summary>
        /// Whether the customer is required to complete the field before completing the Checkout
        /// Session. Defaults to <c>false</c>.
        /// </summary>
        [JsonProperty("optional")]
        [STJS.JsonPropertyName("optional")]
        public bool Optional { get; set; }

        [JsonProperty("text")]
        [STJS.JsonPropertyName("text")]
        public PaymentLinkCustomFieldText Text { get; set; }

        /// <summary>
        /// The type of the field.
        /// One of: <c>dropdown</c>, <c>numeric</c>, or <c>text</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
