namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class ChargePaymentMethodDetailsCardWalletMasterpass : StripeEntity<ChargePaymentMethodDetailsCardWalletMasterpass>
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
