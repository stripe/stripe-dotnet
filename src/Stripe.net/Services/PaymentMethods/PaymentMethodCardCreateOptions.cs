namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentMethodCardCreateOptions : INestedOptions
    {
        [JsonProperty("cvc")]
        public string Cvc { get; set; }

        [JsonProperty("exp_month")]
        public long? ExpMonth { get; set; }

        [JsonProperty("exp_year")]
        public long? ExpYear { get; set; }

        [JsonProperty("number")]
        public string Number { get; set; }

        [JsonProperty("token")]
        public string Token { get; set; }
    }
}
