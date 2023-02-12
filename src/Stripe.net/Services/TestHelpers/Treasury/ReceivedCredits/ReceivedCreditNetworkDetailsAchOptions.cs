// File generated from our OpenAPI spec
namespace Stripe.TestHelpers.Treasury
{
    using Newtonsoft.Json;

    public class ReceivedCreditNetworkDetailsAchOptions : INestedOptions
    {
        /// <summary>
        /// ACH Addenda record.
        /// </summary>
        [JsonProperty("addenda")]
        public string Addenda { get; set; }
    }
}
