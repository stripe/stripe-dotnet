// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentIntentAsyncWorkflowsInputsOptions : INestedOptions
    {
        /// <summary>
        /// Tax arguments for automations.
        /// </summary>
        [JsonProperty("tax")]
        public PaymentIntentAsyncWorkflowsInputsTaxOptions Tax { get; set; }
    }
}
