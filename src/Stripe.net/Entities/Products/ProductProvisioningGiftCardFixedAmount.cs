// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class ProductProvisioningGiftCardFixedAmount : StripeEntity<ProductProvisioningGiftCardFixedAmount>
    {
        /// <summary>
        /// The initial amount with which the provisioned gift card will be created.
        /// </summary>
        [JsonProperty("amount")]
        public long Amount { get; set; }

        /// <summary>
        /// Three-letter <a href="https://www.iso.org/iso-4217-currency-codes.html">ISO currency
        /// code</a>, in lowercase. Must be a <a href="https://stripe.com/docs/currencies">supported
        /// currency</a>.
        /// </summary>
        [JsonProperty("currency")]
        public string Currency { get; set; }
    }
}
