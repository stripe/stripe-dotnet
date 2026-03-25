// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AccountSettingsPaypayPaymentsOptions : INestedOptions
    {
        /// <summary>
        /// Additional files that are required to support the onboarding process of your business.
        /// </summary>
        [JsonProperty("additional_files")]
        [STJS.JsonPropertyName("additional_files")]
        public List<string> AdditionalFiles { get; set; }

        /// <summary>
        /// The type of goods your business sells. Use <c>digital_content</c> if you sell digital
        /// content. Use <c>other</c> for all other types of goods or services.
        /// One of: <c>digital_content</c>, or <c>other</c>.
        /// </summary>
        [JsonProperty("goods_type")]
        [STJS.JsonPropertyName("goods_type")]
        public string GoodsType { get; set; }

        /// <summary>
        /// Details regarding your business's website.
        /// </summary>
        [JsonProperty("site")]
        [STJS.JsonPropertyName("site")]
        public AccountSettingsPaypayPaymentsSiteOptions Site { get; set; }
    }
}
