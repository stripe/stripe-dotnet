// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class ProductProvisioningOptions : INestedOptions
    {
        [JsonProperty("gift_card")]
        public ProductProvisioningGiftCardOptions GiftCard { get; set; }

        /// <summary>
        /// The type of provisioning, only <c>gift_card</c> currently supported.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
