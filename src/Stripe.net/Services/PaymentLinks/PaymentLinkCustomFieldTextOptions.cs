// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentLinkCustomFieldTextOptions : INestedOptions
    {
        /// <summary>
        /// The maximum character length constraint for the customer's input.
        /// </summary>
        [JsonProperty("maximum_length")]
        public long? MaximumLength { get; set; }

        /// <summary>
        /// The minimum character length requirement for the customer's input.
        /// </summary>
        [JsonProperty("minimum_length")]
        public long? MinimumLength { get; set; }
    }
}
