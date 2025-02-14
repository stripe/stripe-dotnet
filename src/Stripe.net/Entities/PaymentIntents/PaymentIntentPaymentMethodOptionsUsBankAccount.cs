// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentIntentPaymentMethodOptionsUsBankAccount : StripeEntity<PaymentIntentPaymentMethodOptionsUsBankAccount>
    {
        [JsonProperty("financial_connections")]
        public PaymentIntentPaymentMethodOptionsUsBankAccountFinancialConnections FinancialConnections { get; set; }

        [JsonProperty("mandate_options")]
        public PaymentIntentPaymentMethodOptionsUsBankAccountMandateOptions MandateOptions { get; set; }

        /// <summary>
        /// Preferred transaction settlement speed.
        /// One of: <c>fastest</c>, or <c>standard</c>.
        /// </summary>
        [JsonProperty("preferred_settlement_speed")]
        public string PreferredSettlementSpeed { get; set; }

        /// <summary>
        /// Indicates that you intend to make future payments with this PaymentIntent's payment
        /// method.
        ///
        /// If you provide a Customer with the PaymentIntent, you can use this parameter to <a
        /// href="https://stripe.com/payments/save-during-payment">attach the payment method</a> to
        /// the Customer after the PaymentIntent is confirmed and the customer completes any
        /// required actions. If you don't provide a Customer, you can still <a
        /// href="https://stripe.com/api/payment_methods/attach">attach</a> the payment method to a
        /// Customer after the transaction completes.
        ///
        /// If the payment method is <c>card_present</c> and isn't a digital wallet, Stripe creates
        /// and attaches a <a
        /// href="https://stripe.com/api/charges/object#charge_object-payment_method_details-card_present-generated_card">generated_card</a>
        /// payment method representing the card to the Customer instead.
        ///
        /// When processing card payments, Stripe uses <c>setup_future_usage</c> to help you comply
        /// with regional legislation and network rules, such as <a
        /// href="https://stripe.com/strong-customer-authentication">SCA</a>.
        /// One of: <c>none</c>, <c>off_session</c>, or <c>on_session</c>.
        /// </summary>
        [JsonProperty("setup_future_usage")]
        public string SetupFutureUsage { get; set; }

        /// <summary>
        /// Controls when Stripe will attempt to debit the funds from the customer's account. The
        /// date must be a string in YYYY-MM-DD format. The date must be in the future and between 3
        /// and 15 calendar days from now.
        /// </summary>
        [JsonProperty("target_date")]
        public string TargetDate { get; set; }

        /// <summary>
        /// Bank account verification method.
        /// One of: <c>automatic</c>, <c>instant</c>, or <c>microdeposits</c>.
        /// </summary>
        [JsonProperty("verification_method")]
        public string VerificationMethod { get; set; }
    }
}
