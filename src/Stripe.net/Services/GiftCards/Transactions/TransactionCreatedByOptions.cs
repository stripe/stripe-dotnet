// File generated from our OpenAPI spec
namespace Stripe.GiftCards
{
    using Newtonsoft.Json;

    public class TransactionCreatedByOptions : INestedOptions
    {
        /// <summary>
        /// The details for the payment that created this object.
        /// </summary>
        [JsonProperty("payment")]
        public TransactionCreatedByPaymentOptions Payment { get; set; }

        /// <summary>
        /// The type of event that created this object.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
