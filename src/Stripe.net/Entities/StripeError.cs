namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class StripeError : StripeEntity<StripeError>
    {
        /*
         * For regular API errors:
         */

        [JsonProperty("charge")]
        public string Charge { get; set; }

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

        [JsonProperty("payment_intent")]
        public PaymentIntent PaymentIntent { get; set; }

        [JsonProperty("payment_method")]
        public PaymentMethod PaymentMethod { get; set; }

        [JsonProperty("setup_intent")]
        public SetupIntent SetupIntent { get; set; }

        [JsonProperty("source")]
        [JsonConverter(typeof(StripeObjectConverter))]
        public IPaymentSource Source { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        /*
         * For OAuth Errors:
         */

        [JsonProperty("error")]
        public string Error { get; set; }

        [JsonProperty("error_description")]
        public string ErrorDescription { get; set; }
    }
}
