// File generated from our OpenAPI spec
namespace Stripe.TestHelpers.Treasury
{
    using Newtonsoft.Json;

    public class ReceivedDebitNetworkDetailsOptions : INestedOptions
    {
        /// <summary>
        /// Optional fields for <c>ach</c>.
        /// </summary>
        [JsonProperty("ach")]
        public ReceivedDebitNetworkDetailsAchOptions Ach { get; set; }

        /// <summary>
        /// The type of flow that originated the ReceivedDebit.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
