namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class PaymentIntentLastPaymentError : StripeEntity
    {
        [JsonProperty("charge")]
        public string ChargeId { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("decline_code")]
        public string DeclineCode { get; set; }

        [JsonProperty("doc_url")]
        public string DocUrl { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("param")]
        public string Param { get; set; }

        [JsonProperty("source")]
        [JsonConverter(typeof(StripeObjectConverter))]
        public IPaymentSource Source { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
