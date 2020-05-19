namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class ChargePaymentMethodDetailsAlipay : StripeEntity<ChargePaymentMethodDetailsAlipay>
    {
        [JsonProperty("fingerprint")]
        public string Fingerprint { get; set; }

        [JsonProperty("transaction_id")]
        public string TransactionId { get; set; }
    }
}
