// File generated from our OpenAPI spec
namespace Stripe.TestHelpers.Treasury
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class InboundTransferFailureDetailsNetworkDetailsAchOptions : INestedOptions
    {
        /// <summary>
        /// NACHA ACH return code.
        /// </summary>
        [JsonProperty("return_code")]
        [STJS.JsonPropertyName("return_code")]
        public string ReturnCode { get; set; }
    }
}
