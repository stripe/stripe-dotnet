namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class ChargePaymentMethodDetailsFpx : StripeEntity
    {
        [JsonProperty("transaction_id")]
        public string TransactionId { get; set; }

        [JsonProperty("bank")]
        public string Bank { get; set; }
    }
}
