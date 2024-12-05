// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class ChargePaymentMethodDetailsSepaDebit : StripeEntity<ChargePaymentMethodDetailsSepaDebit>
    {
        /// <summary>
        /// Bank code of bank associated with the bank account.
        /// </summary>
        [JsonProperty("bank_code")]
        public string BankCode { get; set; }

        /// <summary>
        /// Branch code of bank associated with the bank account.
        /// </summary>
        [JsonProperty("branch_code")]
        public string BranchCode { get; set; }

        /// <summary>
        /// Two-letter ISO code representing the country the bank account is located in.
        /// </summary>
        [JsonProperty("country")]
        public string Country { get; set; }

        /// <summary>
        /// Uniquely identifies this particular bank account. You can use this attribute to check
        /// whether two bank accounts are the same.
        /// </summary>
        [JsonProperty("fingerprint")]
        public string Fingerprint { get; set; }

        /// <summary>
        /// Last four characters of the IBAN.
        /// </summary>
        [JsonProperty("last4")]
        public string Last4 { get; set; }

        /// <summary>
        /// Find the ID of the mandate used for this payment under the <a
        /// href="https://stripe.com/docs/api/charges/object#charge_object-payment_method_details-sepa_debit-mandate">payment_method_details.sepa_debit.mandate</a>
        /// property on the Charge. Use this mandate ID to <a
        /// href="https://stripe.com/docs/api/mandates/retrieve">retrieve the Mandate</a>.
        /// </summary>
        [JsonProperty("mandate")]
        public string Mandate { get; set; }
    }
}
