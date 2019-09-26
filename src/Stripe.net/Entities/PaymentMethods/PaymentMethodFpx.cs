namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentMethodFpx : StripeEntity<PaymentMethodFpx>
    {
        [JsonProperty("account_holder_type")]
        public string AccountHolderType { get; set; }

        [JsonProperty("bank")]
        public string Bank { get; set; }
    }
}
