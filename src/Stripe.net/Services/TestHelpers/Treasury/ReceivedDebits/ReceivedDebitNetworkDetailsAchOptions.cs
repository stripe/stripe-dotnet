// File generated from our OpenAPI spec
namespace Stripe.TestHelpers.Treasury
{
    using Newtonsoft.Json;

    public class ReceivedDebitNetworkDetailsAchOptions : INestedOptions
    {
        /// <summary>
        /// Addenda record data associated with this ReceivedDebit.
        /// </summary>
        [JsonProperty("addenda")]
        public string Addenda { get; set; }
    }
}
