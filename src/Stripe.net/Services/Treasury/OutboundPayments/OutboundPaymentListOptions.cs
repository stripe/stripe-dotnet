// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using Newtonsoft.Json;

    public class OutboundPaymentListOptions : ListOptionsWithCreated
    {
        /// <summary>
        /// Only return OutboundPayments sent to this customer.
        /// </summary>
        [JsonProperty("customer")]
        public string Customer { get; set; }

        /// <summary>
        /// Returns objects associated with this FinancialAccount.
        /// </summary>
        [JsonProperty("financial_account")]
        public string FinancialAccount { get; set; }

        /// <summary>
        /// Only return OutboundPayments that have the given status: <c>processing</c>,
        /// <c>failed</c>, <c>posted</c>, <c>returned</c>, or <c>canceled</c>.
        /// One of: <c>canceled</c>, <c>failed</c>, <c>posted</c>, <c>processing</c>, or
        /// <c>returned</c>.
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }
    }
}
