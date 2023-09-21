// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentIntentListOptions : ListOptionsWithCreated
    {
        /// <summary>
        /// Only return PaymentIntents for the customer specified by this customer ID.
        /// </summary>
        [JsonProperty("customer")]
        public string Customer { get; set; }
    }
}
