// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using Newtonsoft.Json;

    public class OutboundPaymentDestinationPaymentMethodDetailsFinancialAccount : StripeEntity<OutboundPaymentDestinationPaymentMethodDetailsFinancialAccount>, IHasId
    {
        /// <summary>
        /// Token of the FinancialAccount.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// The rails used to send funds.
        /// </summary>
        [JsonProperty("network")]
        public string Network { get; set; }
    }
}
