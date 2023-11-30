// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class CustomerTaxOptions : INestedOptions
    {
        /// <summary>
        /// A recent IP address of the customer used for tax reporting and tax location inference.
        /// Stripe recommends updating the IP address when a new PaymentMethod is attached or the
        /// address field on the customer is updated. We recommend against updating this field more
        /// frequently since it could result in unexpected tax location/reporting outcomes.
        /// </summary>
        [JsonProperty("ip_address")]
        public string IpAddress { get; set; }

        /// <summary>
        /// A flag that indicates when Stripe should validate the customer tax location. Defaults to
        /// <c>deferred</c>.
        /// One of: <c>deferred</c>, or <c>immediately</c>.
        /// </summary>
        [JsonProperty("validate_location")]
        public string ValidateLocation { get; set; }
    }
}
