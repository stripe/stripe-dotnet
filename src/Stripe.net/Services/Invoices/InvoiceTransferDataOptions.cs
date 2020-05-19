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
        /// The account where funds from the payment will be transferred to upon payment success.
        /// </summary>
        [JsonProperty("destination")]
        public string Destination { get; set; }
    }
}
