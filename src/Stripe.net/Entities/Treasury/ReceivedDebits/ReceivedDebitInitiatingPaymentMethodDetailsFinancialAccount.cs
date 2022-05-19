// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using Newtonsoft.Json;

    public class ReceivedDebitInitiatingPaymentMethodDetailsFinancialAccount : StripeEntity<ReceivedDebitInitiatingPaymentMethodDetailsFinancialAccount>, IHasId
    {
        /// <summary>
        /// The FinancialAccount ID.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// The rails the ReceivedCredit was sent over. A FinancialAccount can only send funds over
        /// <c>stripe</c>.
        /// </summary>
        [JsonProperty("network")]
        public string Network { get; set; }
    }
}
