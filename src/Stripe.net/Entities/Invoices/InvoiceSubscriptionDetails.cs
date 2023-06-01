// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class InvoiceSubscriptionDetails : StripeEntity<InvoiceSubscriptionDetails>
    {
        /// <summary>
        /// If specified, payment collection for this subscription will be paused.
        /// </summary>
        [JsonProperty("pause_collection")]
        public InvoiceSubscriptionDetailsPauseCollection PauseCollection { get; set; }
    }
}
