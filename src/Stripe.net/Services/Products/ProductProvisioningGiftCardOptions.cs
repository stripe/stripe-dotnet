// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ProductProvisioningGiftCardOptions : INestedOptions
    {
        [JsonProperty("fixed_amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("fixed_amount")]
#endif
        public ProductProvisioningGiftCardFixedAmountOptions FixedAmount { get; set; }

        /// <summary>
        /// The specific type of gift_card provisioning, only <c>fixed_amount</c> currently
        /// supported.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }
    }
}
