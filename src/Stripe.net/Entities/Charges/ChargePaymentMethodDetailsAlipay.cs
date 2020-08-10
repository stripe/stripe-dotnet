namespace Stripe
{
    using Newtonsoft.Json;

    public class ChargePaymentMethodDetailsAlipay : StripeEntity<ChargePaymentMethodDetailsAlipay>
    {
        [JsonProperty("fingerprint")]
        public string Fingerprint { get; set; }

        [JsonProperty("transaction_id")]
        public string TransactionId { get; set; }
    }
}
