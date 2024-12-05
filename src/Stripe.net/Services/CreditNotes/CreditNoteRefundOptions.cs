// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class CreditNoteRefundOptions : INestedOptions
    {
        /// <summary>
        /// Amount of the refund that applies to this credit note, in cents (or local equivalent).
        /// Defaults to the entire refund amount.
        /// </summary>
        [JsonProperty("amount_refunded")]
        public long? AmountRefunded { get; set; }

        /// <summary>
        /// ID of an existing refund to link this credit note to.
        /// </summary>
        [JsonProperty("refund")]
        public string Refund { get; set; }
    }
}
