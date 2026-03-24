// File generated from our OpenAPI spec
namespace Stripe.Radar
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class CustomerEvaluationSignals : StripeEntity<CustomerEvaluationSignals>
    {
        [JsonProperty("account_sharing")]
        [STJS.JsonPropertyName("account_sharing")]
        public CustomerEvaluationSignalsAccountSharing AccountSharing { get; set; }

        [JsonProperty("multi_accounting")]
        [STJS.JsonPropertyName("multi_accounting")]
        public CustomerEvaluationSignalsMultiAccounting MultiAccounting { get; set; }
    }
}
