namespace Stripe
{
    using Newtonsoft.Json;

    public class CustomerInvoiceSettingsCustomField : StripeEntity<CustomerInvoiceSettingsCustomField>
    {
        /// <summary>
        /// The name of the custom field.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// The value of the custom field.
        /// </summary>
        [JsonProperty("value")]
        public string Value { get; set; }
    }
}
