// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class ProductProvisioning : StripeEntity<ProductProvisioning>
    {
        [JsonProperty("gift_card")]
        public ProductProvisioningGiftCard GiftCard { get; set; }

        /// <summary>
        /// The type of provisioning, only <c>gift_card</c> currently supported.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
