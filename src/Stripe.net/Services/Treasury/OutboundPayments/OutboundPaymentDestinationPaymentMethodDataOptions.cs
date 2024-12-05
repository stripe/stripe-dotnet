// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class OutboundPaymentDestinationPaymentMethodDataOptions : INestedOptions, IHasMetadata
    {
        /// <summary>
        /// Billing information associated with the PaymentMethod that may be used or required by
        /// particular types of payment methods.
        /// </summary>
        [JsonProperty("billing_details")]
        public OutboundPaymentDestinationPaymentMethodDataBillingDetailsOptions BillingDetails { get; set; }

        /// <summary>
        /// Required if type is set to <c>financial_account</c>. The FinancialAccount ID to send
        /// funds to.
        /// </summary>
        [JsonProperty("financial_account")]
        public string FinancialAccount { get; set; }

        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format. Individual keys can be unset by posting an empty value to
        /// them. All keys can be unset by posting an empty value to <c>metadata</c>.
        /// </summary>
        [JsonProperty("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// The type of the PaymentMethod. An additional hash is included on the PaymentMethod with
        /// a name matching this value. It contains additional information specific to the
        /// PaymentMethod type.
        /// One of: <c>financial_account</c>, or <c>us_bank_account</c>.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// Required hash if type is set to <c>us_bank_account</c>.
        /// </summary>
        [JsonProperty("us_bank_account")]
        public OutboundPaymentDestinationPaymentMethodDataUsBankAccountOptions UsBankAccount { get; set; }
    }
}
