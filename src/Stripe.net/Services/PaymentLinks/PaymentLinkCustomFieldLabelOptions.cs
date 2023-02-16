// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentLinkCustomFieldLabelOptions : INestedOptions
    {
        /// <summary>
        /// Custom text for the label, displayed to the customer. Up to 50 characters.
        /// </summary>
        [JsonProperty("custom")]
        public string Custom { get; set; }

        /// <summary>
        /// The type of the label.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
