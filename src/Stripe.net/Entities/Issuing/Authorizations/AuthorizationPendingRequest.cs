namespace Stripe.Issuing
{
    using Newtonsoft.Json;

    public class AuthorizationPendingRequest : StripeEntity<AuthorizationPendingRequest>
    {
        [JsonProperty("amount")]
        public long Amount { get; set; }

        [JsonProperty("currency")]
        public string Currency { get; set; }

        [JsonProperty("is_amount_controllable")]
        public bool IsAmountControllable { get; set; }

        [JsonProperty("merchant_amount")]
        public long MerchantAmount { get; set; }

        [JsonProperty("merchant_currency")]
        public string MerchantCurrency { get; set; }
    }
}
