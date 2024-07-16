// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentIntentAsyncWorkflowsInputs : StripeEntity<PaymentIntentAsyncWorkflowsInputs>
    {
        [JsonProperty("tax")]
        public PaymentIntentAsyncWorkflowsInputsTax Tax { get; set; }
    }
}
