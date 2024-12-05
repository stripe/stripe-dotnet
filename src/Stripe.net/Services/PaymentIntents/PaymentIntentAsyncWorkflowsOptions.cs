// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentIntentAsyncWorkflowsOptions : INestedOptions
    {
        /// <summary>
        /// Arguments passed in automations.
        /// </summary>
        [JsonProperty("inputs")]
        public PaymentIntentAsyncWorkflowsInputsOptions Inputs { get; set; }
    }
}
