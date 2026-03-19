// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PaymentIntentAsyncWorkflows : StripeEntity<PaymentIntentAsyncWorkflows>
    {
        [JsonProperty("inputs")]
        [STJS.JsonPropertyName("inputs")]
        public PaymentIntentAsyncWorkflowsInputs Inputs { get; set; }
    }
}
