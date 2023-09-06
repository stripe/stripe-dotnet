// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class OrderPaymentSettingsPaymentMethodOptionsCustomerBalanceBankTransfer : StripeEntity<OrderPaymentSettingsPaymentMethodOptionsCustomerBalanceBankTransfer>
    {
        [JsonProperty("eu_bank_transfer")]
        public OrderPaymentSettingsPaymentMethodOptionsCustomerBalanceBankTransferEuBankTransfer EuBankTransfer { get; set; }

        /// <summary>
        /// List of address types that should be returned in the financial_addresses response. If
        /// not specified, all valid types will be returned.
        ///
        /// Permitted values include: <c>sort_code</c>, <c>zengin</c>, <c>iban</c>, <c>spei</c>, or
        /// <c>ca_bank_account_address</c>.
        /// </summary>
        [JsonProperty("requested_address_types")]
        public List<string> RequestedAddressTypes { get; set; }

        /// <summary>
        /// The bank transfer type that this PaymentIntent is allowed to use for funding Permitted
        /// values include: <c>eu_bank_transfer</c>, <c>gb_bank_transfer</c>,
        /// <c>jp_bank_transfer</c>, <c>mx_bank_transfer</c>, or <c>us_bank_transfer</c>.
        /// One of: <c>eu_bank_transfer</c>, <c>gb_bank_transfer</c>, <c>jp_bank_transfer</c>,
        /// <c>mx_bank_transfer</c>, or <c>us_bank_transfer</c>.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
