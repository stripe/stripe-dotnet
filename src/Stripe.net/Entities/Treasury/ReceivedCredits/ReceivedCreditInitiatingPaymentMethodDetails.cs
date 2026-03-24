// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ReceivedCreditInitiatingPaymentMethodDetails : StripeEntity<ReceivedCreditInitiatingPaymentMethodDetails>
    {
        /// <summary>
        /// Set when <c>type</c> is <c>balance</c>.
        /// </summary>
        [JsonProperty("balance")]
        [STJS.JsonPropertyName("balance")]
        public string Balance { get; set; }

        [JsonProperty("billing_details")]
        [STJS.JsonPropertyName("billing_details")]
        public ReceivedCreditInitiatingPaymentMethodDetailsBillingDetails BillingDetails { get; set; }

        [JsonProperty("financial_account")]
        [STJS.JsonPropertyName("financial_account")]
        public ReceivedCreditInitiatingPaymentMethodDetailsFinancialAccount FinancialAccount { get; set; }

        /// <summary>
        /// Set when <c>type</c> is <c>issuing_card</c>. This is an <a
        /// href="https://api.stripe.com#issuing_cards">Issuing Card</a> ID.
        /// </summary>
        [JsonProperty("issuing_card")]
        [STJS.JsonPropertyName("issuing_card")]
        public string IssuingCard { get; set; }

        /// <summary>
        /// Polymorphic type matching the originating money movement's source. This can be an
        /// external account, a Stripe balance, or a FinancialAccount.
        /// One of: <c>balance</c>, <c>financial_account</c>, <c>issuing_card</c>, <c>stripe</c>, or
        /// <c>us_bank_account</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonProperty("us_bank_account")]
        [STJS.JsonPropertyName("us_bank_account")]
        public ReceivedCreditInitiatingPaymentMethodDetailsUsBankAccount UsBankAccount { get; set; }
    }
}
