// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentIntentAsyncWorkflowsInputsTax : StripeEntity<PaymentIntentAsyncWorkflowsInputsTax>
    {
        /// <summary>
        /// The <a href="https://stripe.com/docs/api/tax/calculations">TaxCalculation</a> id.
        /// </summary>
        [JsonProperty("calculation")]
        public string Calculation { get; set; }
    }
}
