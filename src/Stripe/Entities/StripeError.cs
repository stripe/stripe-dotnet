using Newtonsoft.Json;

namespace Stripe
{
    public class StripeError : StripeEntity
    {
        [JsonProperty("type")]
        public string ErrorType { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("param")]
        public string Parameter { get; set; }

        [JsonProperty("error")]
        public string Error { get; set; }

        [JsonProperty("error_description")]
        public string ErrorSubscription { get; set; }

        [JsonProperty("charge")]
        public string ChargeId { get; set; }

        [JsonProperty("decline_code")]
        public string DeclineCode { get; set; }
    }
}
