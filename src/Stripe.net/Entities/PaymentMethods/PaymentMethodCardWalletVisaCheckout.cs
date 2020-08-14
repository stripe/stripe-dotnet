namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentMethodCardWalletVisaCheckout : StripeEntity<PaymentMethodCardWalletVisaCheckout>
    {
        /// <summary>
        /// Owner's verified billing address. Values are verified or provided by the wallet directly
        /// (if supported) at the time of authorization or settlement. They cannot be set or
        /// mutated.
        /// </summary>
        [JsonProperty("billing_address")]
        public Address BillingAddress { get; set; }

        /// <summary>
        /// Owner's verified email. Values are verified or provided by the wallet directly (if
        /// supported) at the time of authorization or settlement. They cannot be set or mutated.
        /// </summary>
        [JsonProperty("email")]
        public string Email { get; set; }

        /// <summary>
        /// Owner's verified full name. Values are verified or provided by the wallet directly (if
        /// supported) at the time of authorization or settlement. They cannot be set or mutated.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Owner's verified shipping address. Values are verified or provided by the wallet
        /// directly (if supported) at the time of authorization or settlement. They cannot be set
        /// or mutated.
        /// </summary>
        [JsonProperty("shipping_address")]
        public Address ShippingAddress { get; set; }
    }
}
