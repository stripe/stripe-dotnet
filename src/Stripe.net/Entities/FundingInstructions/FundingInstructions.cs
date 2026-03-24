// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    /// <summary>
    /// Each customer has a <a
    /// href="https://docs.stripe.com/api/customers/object#customer_object-balance"><c>balance</c></a>
    /// that is automatically applied to future invoices and payments using the
    /// <c>customer_balance</c> payment method. Customers can fund this balance by initiating a
    /// bank transfer to any account in the <c>financial_addresses</c> field. Related guide: <a
    /// href="https://docs.stripe.com/payments/customer-balance/funding-instructions">Customer
    /// balance funding instructions</a>.
    /// </summary>
    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class FundingInstructions : StripeEntity<FundingInstructions>, IHasObject
    {
        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value.
        /// </summary>
        [JsonProperty("object")]
        [STJS.JsonPropertyName("object")]
        public string Object { get; set; }

        [JsonProperty("bank_transfer")]
        [STJS.JsonPropertyName("bank_transfer")]
        public FundingInstructionsBankTransfer BankTransfer { get; set; }

        /// <summary>
        /// Three-letter <a href="https://www.iso.org/iso-4217-currency-codes.html">ISO currency
        /// code</a>, in lowercase. Must be a <a href="https://stripe.com/docs/currencies">supported
        /// currency</a>.
        /// </summary>
        [JsonProperty("currency")]
        [STJS.JsonPropertyName("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// The <c>funding_type</c> of the returned instructions.
        /// </summary>
        [JsonProperty("funding_type")]
        [STJS.JsonPropertyName("funding_type")]
        public string FundingType { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
        [STJS.JsonPropertyName("livemode")]
        public bool Livemode { get; set; }
    }
}
