namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentMethodCardWalletMasterpass : StripeEntity<PaymentMethodCardWalletMasterpass>
    {
        [JsonProperty("billing_address")]
        public Address BillingAddress { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("shipping_address")]
        public Address ShippingAddress { get; set; }
    }
}
