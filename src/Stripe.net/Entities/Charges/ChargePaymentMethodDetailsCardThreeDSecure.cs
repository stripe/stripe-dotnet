namespace Stripe
{
    using Newtonsoft.Json;

    public class ChargePaymentMethodDetailsCardThreeDSecure : StripeEntity<ChargePaymentMethodDetailsCardThreeDSecure>
    {
        [JsonProperty("authenticated")]
        public bool Authenticated { get; set; }

        [JsonProperty("authentication_flow")]
        public string AuthenticationFlow { get; set; }

        [JsonProperty("result")]
        public string Result { get; set; }

        [JsonProperty("result_reason")]
        public string ResultReason { get; set; }

        [JsonProperty("succeeded")]
        public bool Succeeded { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }
    }
}
