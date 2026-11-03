// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AccountCreateConfigurationMerchantPaypayPaymentsOptions : INestedOptions
    {
        /// <summary>
        /// Additional files supporting PayPay payments configuration.
        /// </summary>
        [JsonProperty("additional_files")]
        [STJS.JsonPropertyName("additional_files")]
        public List<string> AdditionalFiles { get; set; }

        /// <summary>
        /// The type of goods sold by the merchant for PayPay payments.
        /// One of: <c>digital_content</c>, or <c>other</c>.
        /// </summary>
        [JsonProperty("goods_type")]
        [STJS.JsonPropertyName("goods_type")]
        public string GoodsType { get; set; }

        /// <summary>
        /// URL to the Specified Commercial Transactions Act page for PayPay payments.
        /// </summary>
        [JsonProperty("specified_commercial_transactions_act_url")]
        [STJS.JsonPropertyName("specified_commercial_transactions_act_url")]
        public string SpecifiedCommercialTransactionsActUrl { get; set; }
    }
}
