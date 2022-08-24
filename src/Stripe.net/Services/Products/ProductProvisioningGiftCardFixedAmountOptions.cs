// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class ProductProvisioningGiftCardFixedAmountOptions : INestedOptions
    {
        /// <summary>
        /// The initial amount with which the provisioned gift card will be created.
        /// </summary>
        [JsonProperty("amount")]
        public long? Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }
    }
}
