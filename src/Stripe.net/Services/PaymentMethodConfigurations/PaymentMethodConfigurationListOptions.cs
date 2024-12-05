// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentMethodConfigurationListOptions : ListOptions
    {
        /// <summary>
        /// The Connect application to filter by.
        /// </summary>
        [JsonProperty("application")]
        public string Application { get; set; }
    }
}
