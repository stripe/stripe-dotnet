// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using Newtonsoft.Json;

    public class SessionPaymentMethodOptionsOptions : INestedOptions
    {
        /// <summary>
        /// contains details about the ACSS Debit payment method options.
        /// </summary>
        [JsonProperty("acss_debit")]
        public SessionPaymentMethodOptionsAcssDebitOptions AcssDebit { get; set; }
    }
}
