// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class OrderSubmitOptions : BaseOptions
    {
        /// <summary>
        /// <c>expected_total</c> should always be set to the order's <c>amount_total</c> field. If
        /// they don't match, submitting the order will fail. This helps detect race conditions
        /// where something else concurrently modifies the order.
        /// </summary>
        [JsonProperty("expected_total")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("expected_total")]
#endif
        public long? ExpectedTotal { get; set; }
    }
}
