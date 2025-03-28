// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountConfigurationCustomerBillingInvoiceCustomField : StripeEntity<AccountConfigurationCustomerBillingInvoiceCustomField>
    {
        /// <summary>
        /// The name of the custom field. This may be up to 40 characters.
        /// </summary>
        [JsonProperty("name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("name")]
#endif
        public string Name { get; set; }

        /// <summary>
        /// The value of the custom field. This may be up to 140 characters. When updating, pass an
        /// empty string to remove previously-defined values.
        /// </summary>
        [JsonProperty("value")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("value")]
#endif
        public string Value { get; set; }
    }
}
