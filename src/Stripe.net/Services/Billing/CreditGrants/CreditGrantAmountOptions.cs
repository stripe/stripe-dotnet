// File generated from our OpenAPI spec
namespace Stripe.Billing
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class CreditGrantAmountOptions : INestedOptions
    {
        /// <summary>
        /// The monetary amount.
        /// </summary>
        [JsonProperty("monetary")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("monetary")]
#endif
        public CreditGrantAmountMonetaryOptions Monetary { get; set; }

        /// <summary>
        /// Specify the type of this amount. We currently only support <c>monetary</c> billing
        /// credits.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }
    }
}
