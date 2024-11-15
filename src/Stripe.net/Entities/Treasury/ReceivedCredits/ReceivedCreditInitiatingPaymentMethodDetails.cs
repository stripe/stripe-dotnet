// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ReceivedCreditInitiatingPaymentMethodDetails : StripeEntity<ReceivedCreditInitiatingPaymentMethodDetails>
    {
        /// <summary>
        /// Set when <c>type</c> is <c>balance</c>.
        /// </summary>
        [JsonProperty("balance")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("balance")]
#endif

        public string Balance { get; set; }

        [JsonProperty("billing_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("billing_details")]
#endif

        public ReceivedCreditInitiatingPaymentMethodDetailsBillingDetails BillingDetails { get; set; }

        [JsonProperty("financial_account")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("financial_account")]
#endif

        public ReceivedCreditInitiatingPaymentMethodDetailsFinancialAccount FinancialAccount { get; set; }

        /// <summary>
        /// Set when <c>type</c> is <c>issuing_card</c>. This is an <a
        /// href="https://stripe.com/docs/api#issuing_cards">Issuing Card</a> ID.
        /// </summary>
        [JsonProperty("issuing_card")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("issuing_card")]
#endif

        public string IssuingCard { get; set; }

        /// <summary>
        /// Polymorphic type matching the originating money movement's source. This can be an
        /// external account, a Stripe balance, or a FinancialAccount.
        /// One of: <c>balance</c>, <c>financial_account</c>, <c>issuing_card</c>, <c>stripe</c>, or
        /// <c>us_bank_account</c>.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif

        public string Type { get; set; }

        [JsonProperty("us_bank_account")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("us_bank_account")]
#endif

        public ReceivedCreditInitiatingPaymentMethodDetailsUsBankAccount UsBankAccount { get; set; }
    }
}
