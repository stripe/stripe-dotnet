// File generated from our OpenAPI spec
namespace Stripe.Tax
{
    using Newtonsoft.Json;

    public class SettingsHeadOfficeOptions : INestedOptions
    {
        /// <summary>
        /// The location of the business for tax purposes.
        /// </summary>
        [JsonProperty("address")]
        public AddressOptions Address { get; set; }
    }
}
