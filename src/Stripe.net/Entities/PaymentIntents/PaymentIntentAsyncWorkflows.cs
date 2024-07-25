// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentIntentAsyncWorkflows : StripeEntity<PaymentIntentAsyncWorkflows>
    {
        [JsonProperty("inputs")]
        public PaymentIntentAsyncWorkflowsInputs Inputs { get; set; }
    }
}
