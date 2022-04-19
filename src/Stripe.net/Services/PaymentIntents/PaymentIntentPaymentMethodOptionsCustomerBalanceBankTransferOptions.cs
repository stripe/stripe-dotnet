// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class PaymentIntentPaymentMethodOptionsCustomerBalanceBankTransferOptions : INestedOptions
    {
        /// <summary>
        /// List of address types that should be returned in the financial_addresses response. If
        /// not specified, all valid types will be returned.
        ///
        /// Permitted values include: <c>zengin</c>.
        /// </summary>
        [JsonProperty("requested_address_types")]
        public List<string> RequestedAddressTypes { get; set; }

        /// <summary>
        /// The list of bank transfer types that this PaymentIntent is allowed to use for funding.
        /// Permitted values include: <c>us_bank_account</c>, <c>eu_bank_account</c>,
        /// <c>id_bank_account</c>, <c>gb_bank_account</c>, <c>jp_bank_account</c>,
        /// <c>mx_bank_account</c>, <c>eu_bank_transfer</c>, <c>gb_bank_transfer</c>,
        /// <c>id_bank_transfer</c>, <c>jp_bank_transfer</c>, <c>mx_bank_transfer</c>, or
        /// <c>us_bank_transfer</c>.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
