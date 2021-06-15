namespace Stripe
{
    using Newtonsoft.Json;
    
    public class PaymentIntentPaymentMethodCard : INestedOptions
    {
        [JsonProperty("token")]
        public string Token { get; set; }
    }
}
