// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using Newtonsoft.Json;

    public class ReceivedDebitInitiatingPaymentMethodDetails : StripeEntity<ReceivedDebitInitiatingPaymentMethodDetails>
    {
        /// <summary>
        /// Set when <c>type</c> is <c>balance</c>.
        /// </summary>
        [JsonProperty("balance")]
        public string Balance { get; set; }

        [JsonProperty("billing_details")]
        public ReceivedDebitInitiatingPaymentMethodDetailsBillingDetails BillingDetails { get; set; }

        [JsonProperty("financial_account")]
        public ReceivedDebitInitiatingPaymentMethodDetailsFinancialAccount FinancialAccount { get; set; }

        /// <summary>
        /// Set when <c>type</c> is <c>issuing_card</c>. This is an <a
        /// href="https://stripe.com/docs/api#issuing_cards">Issuing Card</a> ID.
        /// </summary>
        [JsonProperty("issuing_card")]
        public string IssuingCard { get; set; }

        /// <summary>
        /// Polymorphic type matching the originating money movement's source. This can be an
        /// external account, a Stripe balance, or a FinancialAccount.
        /// One of: <c>balance</c>, <c>financial_account</c>, <c>issuing_card</c>, <c>stripe</c>, or
        /// <c>us_bank_account</c>.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("us_bank_account")]
        public ReceivedDebitInitiatingPaymentMethodDetailsUsBankAccount UsBankAccount { get; set; }
    }
}
