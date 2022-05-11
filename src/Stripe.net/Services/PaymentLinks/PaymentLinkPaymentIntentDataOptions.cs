// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentLinkPaymentIntentDataOptions : INestedOptions
    {
        /// <summary>
        /// Controls when the funds will be captured from the customer's account.
        /// One of: <c>automatic</c>, or <c>manual</c>.
        /// </summary>
        [JsonProperty("capture_method")]
        public string CaptureMethod { get; set; }

        /// <summary>
        /// Indicates that you intend to <a
        /// href="https://stripe.com/docs/payments/payment-intents#future-usage">make future
        /// payments</a> with the payment method collected by this Checkout Session.
        ///
        /// When setting this to <c>on_session</c>, Checkout will show a notice to the customer that
        /// their payment details will be saved.
        ///
        /// When setting this to <c>off_session</c>, Checkout will show a notice to the customer
        /// that their payment details will be saved and used for future payments.
        ///
        /// If a Customer has been provided or Checkout creates a new Customer,Checkout will attach
        /// the payment method to the Customer.
        ///
        /// If Checkout does not create a Customer, the payment method is not attached to a
        /// Customer. To reuse the payment method, you can retrieve it from the Checkout Session's
        /// PaymentIntent.
        ///
        /// When processing card payments, Checkout also uses <c>setup_future_usage</c> to
        /// dynamically optimize your payment flow and comply with regional legislation and network
        /// rules, such as SCA.
        /// One of: <c>off_session</c>, or <c>on_session</c>.
        /// </summary>
        [JsonProperty("setup_future_usage")]
        public string SetupFutureUsage { get; set; }
    }
}
