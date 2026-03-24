// File generated from our OpenAPI spec
namespace Stripe.TestHelpers.Treasury
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class ReceivedDebitNetworkDetailsAchOptions : INestedOptions
    {
        /// <summary>
        /// Addenda record data associated with this ReceivedDebit.
        /// </summary>
        [JsonProperty("addenda")]
        [STJS.JsonPropertyName("addenda")]
        public string Addenda { get; set; }
    }
}
