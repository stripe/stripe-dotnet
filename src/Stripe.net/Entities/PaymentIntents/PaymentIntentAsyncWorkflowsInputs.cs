// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PaymentIntentAsyncWorkflowsInputs : StripeEntity<PaymentIntentAsyncWorkflowsInputs>
    {
        [JsonProperty("tax")]
        [STJS.JsonPropertyName("tax")]
        public PaymentIntentAsyncWorkflowsInputsTax Tax { get; set; }
    }
}
