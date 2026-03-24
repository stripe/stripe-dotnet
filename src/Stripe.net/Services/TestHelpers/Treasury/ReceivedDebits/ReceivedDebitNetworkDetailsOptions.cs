// File generated from our OpenAPI spec
namespace Stripe.TestHelpers.Treasury
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class ReceivedDebitNetworkDetailsOptions : INestedOptions
    {
        /// <summary>
        /// Optional fields for <c>ach</c>.
        /// </summary>
        [JsonProperty("ach")]
        [STJS.JsonPropertyName("ach")]
        public ReceivedDebitNetworkDetailsAchOptions Ach { get; set; }

        /// <summary>
        /// The type of flow that originated the ReceivedDebit.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
