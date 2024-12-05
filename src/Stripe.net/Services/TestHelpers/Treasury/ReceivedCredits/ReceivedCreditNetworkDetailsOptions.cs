// File generated from our OpenAPI spec
namespace Stripe.TestHelpers.Treasury
{
    using Newtonsoft.Json;

    public class ReceivedCreditNetworkDetailsOptions : INestedOptions
    {
        /// <summary>
        /// Optional fields for <c>ach</c>.
        /// </summary>
        [JsonProperty("ach")]
        public ReceivedCreditNetworkDetailsAchOptions Ach { get; set; }

        /// <summary>
        /// The type of flow that originated the ReceivedCredit.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
