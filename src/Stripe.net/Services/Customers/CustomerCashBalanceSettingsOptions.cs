// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class CustomerCashBalanceSettingsOptions : INestedOptions
    {
        /// <summary>
        /// Method for using the customer balance to pay outstanding <c>customer_balance</c>
        /// PaymentIntents. If set to <c>automatic</c>, all available funds will automatically be
        /// used to pay any outstanding PaymentIntent. If set to <c>manual</c>, only customer
        /// balance funds from bank transfers with a reference code matching
        /// <c>payment_intent.next_action.display_bank_transfer_intructions.reference_code</c> will
        /// automatically be used to pay the corresponding outstanding PaymentIntent.
        /// One of: <c>automatic</c>, or <c>manual</c>.
        /// </summary>
        [JsonProperty("reconciliation_mode")]
        public string ReconciliationMode { get; set; }
    }
}
