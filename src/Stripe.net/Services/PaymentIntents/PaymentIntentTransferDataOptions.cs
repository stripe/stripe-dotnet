namespace Stripe
{
    using System;
    using Newtonsoft.Json;

    public class PaymentIntentTransferDataOptions : INestedOptions
    {
        /// <summary>
        /// The amount transferred to the destination account, if specified. By default, the entire
        /// charge amount is transferred to the destination account.
        /// </summary>
        [JsonProperty("amount")]
        public long? Amount { get; set; }

        /// <summary>
        /// If specified, successful charges will be attributed to the destination account for tax
        /// reporting, and the funds from charges will be transferred to the destination account.
        /// The ID of the resulting transfer will be returned on the successful charge’s transfer
        /// field.
        /// </summary>
        [JsonProperty("destination")]
        public string Destination { get; set; }
    }
}
