namespace Stripe
{
    using System;
    using Newtonsoft.Json;

    public class SessionPaymentIntentTransferDataOptions : INestedOptions
    {
        /// <summary>
        /// The amount that will be transferred automatically when a charge succeeds.
        /// </summary>
        [JsonProperty("amount")]
        public long? Amount { get; set; }

        /// <summary>
        /// If specified, successful charges will be attributed to the destination account for tax
        /// reporting, and the funds from charges will be transferred to the destination account.
        /// The ID of the resulting transfer will be returned on the successful charge’s
        /// <see cref="Transfer"/> field.
        /// </summary>
        [JsonProperty("destination")]
        public string Destination { get; set; }
    }
}
