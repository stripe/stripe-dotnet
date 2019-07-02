namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentIntentListOptions : ListOptionsWithCreated
    {
        /// <summary>
        /// Only return PaymentIntents for the customer specified by this customer ID.
        /// </summary>
        [JsonProperty("customer")]
        public string CustomerId { get; set; }
    }
}
