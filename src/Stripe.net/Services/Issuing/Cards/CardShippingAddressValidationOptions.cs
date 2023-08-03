// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using Newtonsoft.Json;

    public class CardShippingAddressValidationOptions : INestedOptions
    {
        /// <summary>
        /// The address validation capabilities to use.
        /// One of: <c>disabled</c>, <c>normalization_only</c>, or
        /// <c>validation_and_normalization</c>.
        /// </summary>
        [JsonProperty("mode")]
        public string Mode { get; set; }
    }
}
