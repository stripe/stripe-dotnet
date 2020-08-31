namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentIntentTransferDataOptions : INestedOptions
    {
        /// <summary>
        /// The amount that will be transferred automatically when a charge succeeds. The amount is
        /// capped at the total transaction amount and if no amount is set, the full amount is
        /// transferred.
        ///
        /// If you intend to collect a fee and you need a more robust reporting experience, using <a
        /// href="https://stripe.com/docs/api/payment_intents/create#create_payment_intent-application_fee_amount">application_fee_amount</a>
        /// might be a better fit for your integration.
        /// </summary>
        [JsonProperty("amount")]
        public long? Amount { get; set; }

        /// <summary>
        /// If specified, successful charges will be attributed to the destination account for tax
        /// reporting, and the funds from charges will be transferred to the destination account.
        /// The ID of the resulting transfer will be returned on the successful charge's
        /// <c>transfer</c> field.
        /// </summary>
        [JsonProperty("destination")]
        public string Destination { get; set; }
    }
}
