// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentIntentListOptions : ListOptionsWithCreated
    {
        /// <summary>
        /// Only return PaymentIntents for the customer that this customer ID specifies.
        /// </summary>
        [JsonProperty("customer")]
        public string Customer { get; set; }
    }
}
