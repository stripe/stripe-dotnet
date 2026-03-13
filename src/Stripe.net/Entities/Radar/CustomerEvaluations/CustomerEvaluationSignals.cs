// File generated from our OpenAPI spec
namespace Stripe.Radar
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class CustomerEvaluationSignals : StripeEntity<CustomerEvaluationSignals>
    {
        [JsonProperty("account_sharing")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("account_sharing")]
#endif
        public CustomerEvaluationSignalsAccountSharing AccountSharing { get; set; }

        [JsonProperty("multi_accounting")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("multi_accounting")]
#endif
        public CustomerEvaluationSignalsMultiAccounting MultiAccounting { get; set; }
    }
}
