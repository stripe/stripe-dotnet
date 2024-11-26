// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class SessionPaymentMethodOptionsCustomerBalanceBankTransferOptions : INestedOptions
    {
        /// <summary>
        /// Configuration for eu_bank_transfer funding type.
        /// </summary>
        [JsonProperty("eu_bank_transfer")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("eu_bank_transfer")]
#endif
        public SessionPaymentMethodOptionsCustomerBalanceBankTransferEuBankTransferOptions EuBankTransfer { get; set; }

        /// <summary>
        /// List of address types that should be returned in the financial_addresses response. If
        /// not specified, all valid types will be returned.
        ///
        /// Permitted values include: <c>sort_code</c>, <c>zengin</c>, <c>iban</c>, or <c>spei</c>.
        /// One of: <c>aba</c>, <c>iban</c>, <c>sepa</c>, <c>sort_code</c>, <c>spei</c>,
        /// <c>swift</c>, or <c>zengin</c>.
        /// </summary>
        [JsonProperty("requested_address_types")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("requested_address_types")]
#endif
        public List<string> RequestedAddressTypes { get; set; }

        /// <summary>
        /// The list of bank transfer types that this PaymentIntent is allowed to use for funding.
        /// One of: <c>eu_bank_transfer</c>, <c>gb_bank_transfer</c>, <c>jp_bank_transfer</c>,
        /// <c>mx_bank_transfer</c>, or <c>us_bank_transfer</c>.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }
    }
}
