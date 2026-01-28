// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountSettingsPaypayPaymentsOptions : INestedOptions
    {
        /// <summary>
        /// Additional files that are required to support the onboarding process of your business.
        /// </summary>
        [JsonProperty("additional_files")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("additional_files")]
#endif
        public List<string> AdditionalFiles { get; set; }

        /// <summary>
        /// Whether your business sells digital content or not.
        /// One of: <c>digital_content</c>, or <c>other</c>.
        /// </summary>
        [JsonProperty("goods_type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("goods_type")]
#endif
        public string GoodsType { get; set; }

        /// <summary>
        /// Details regarding your business's website.
        /// </summary>
        [JsonProperty("site")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("site")]
#endif
        public AccountSettingsPaypayPaymentsSiteOptions Site { get; set; }
    }
}
