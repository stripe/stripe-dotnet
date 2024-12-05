// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentLinkCustomField : StripeEntity<PaymentLinkCustomField>
    {
        [JsonProperty("dropdown")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("dropdown")]
#endif
        public PaymentLinkCustomFieldDropdown Dropdown { get; set; }

        /// <summary>
        /// String of your choice that your integration can use to reconcile this field. Must be
        /// unique to this field, alphanumeric, and up to 200 characters.
        /// </summary>
        [JsonProperty("key")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("key")]
#endif
        public string Key { get; set; }

        [JsonProperty("label")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("label")]
#endif
        public PaymentLinkCustomFieldLabel Label { get; set; }

        [JsonProperty("numeric")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("numeric")]
#endif
        public PaymentLinkCustomFieldNumeric Numeric { get; set; }

        /// <summary>
        /// Whether the customer is required to complete the field before completing the Checkout
        /// Session. Defaults to <c>false</c>.
        /// </summary>
        [JsonProperty("optional")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("optional")]
#endif
        public bool Optional { get; set; }

        [JsonProperty("text")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("text")]
#endif
        public PaymentLinkCustomFieldText Text { get; set; }

        /// <summary>
        /// The type of the field.
        /// One of: <c>dropdown</c>, <c>numeric</c>, or <c>text</c>.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }
    }
}
