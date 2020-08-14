namespace Stripe
{
    using Newtonsoft.Json;

    public class InvoiceTransferDataOptions : INestedOptions
    {
        /// <summary>
        /// The amount that will be transferred automatically when the invoice is paid. If no amount
        /// is set, the full amount is transferred.
        /// </summary>
        [JsonProperty("amount")]
        public long? Amount { get; set; }

        /// <summary>
        /// ID of an existing, connected Stripe account.
        /// </summary>
        [JsonProperty("destination")]
        public string Destination { get; set; }
    }
}
