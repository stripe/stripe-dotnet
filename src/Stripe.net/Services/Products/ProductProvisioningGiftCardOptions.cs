// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class ProductProvisioningGiftCardOptions : INestedOptions
    {
        [JsonProperty("fixed_amount")]
        public ProductProvisioningGiftCardFixedAmountOptions FixedAmount { get; set; }

        /// <summary>
        /// The specific type of gift_card provisioning, only <c>fixed_amount</c> currently
        /// supported.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
