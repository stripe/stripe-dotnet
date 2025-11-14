// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountSettingsPaypayPaymentsOptions : INestedOptions
    {
        /// <summary>
        /// Whether your business sells digital content or not.
        /// One of: <c>digital_content</c>, or <c>other</c>.
        /// </summary>
        [JsonProperty("goods_type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("goods_type")]
#endif
        public string GoodsType { get; set; }
    }
}
