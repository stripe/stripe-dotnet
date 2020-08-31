namespace Stripe
{
    using Newtonsoft.Json;

    public class CustomerInvoiceSettingsCustomFieldOptions : INestedOptions
    {
        /// <summary>
        /// The name of the custom field. This may be up to 30 characters.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// The value of the custom field. This may be up to 30 characters.
        /// </summary>
        [JsonProperty("value")]
        public string Value { get; set; }
    }
}
