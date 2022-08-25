// File generated from our OpenAPI spec
namespace Stripe.GiftCards
{
    using Newtonsoft.Json;

    public class TransactionCreatedByPaymentOptions : INestedOptions
    {
        /// <summary>
        /// The PaymentIntent used to collect payment for this object.
        /// </summary>
        [JsonProperty("payment_intent")]
        public string PaymentIntent { get; set; }
    }
}
