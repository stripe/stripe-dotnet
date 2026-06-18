// File generated from our OpenAPI spec
namespace Stripe.TestHelpers.Issuing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class TransactionNetworkDataOptions : INestedOptions
    {
        /// <summary>
        /// Optional. A test value to populate network_data.acquirer_reference_number on the
        /// resulting Issuing Transaction. Must contain only digits and be at most 23 characters
        /// long. This value is intended only for integration validation in testmode and does not
        /// need to correspond to a real network-assigned acquirer reference number.
        /// </summary>
        [JsonProperty("acquirer_reference_number")]
        [STJS.JsonPropertyName("acquirer_reference_number")]
        public string AcquirerReferenceNumber { get; set; }
    }
}
