// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class CollectionSettingUpdatePaymentMethodOptionsUsBankAccountFinancialConnectionsOptions : INestedOptions
    {
        /// <summary>
        /// Provide filters for the linked accounts that the customer can select for the payment
        /// method.
        /// </summary>
        [JsonProperty("filters")]
        [STJS.JsonPropertyName("filters")]
        public CollectionSettingUpdatePaymentMethodOptionsUsBankAccountFinancialConnectionsFiltersOptions Filters { get; set; }

        /// <summary>
        /// The list of permissions to request. If this parameter is passed, the
        /// <c>payment_method</c> permission must be included.
        /// One of: <c>balances</c>, <c>ownership</c>, <c>payment_method</c>, or
        /// <c>transactions</c>.
        /// </summary>
        [JsonProperty("permissions")]
        [STJS.JsonPropertyName("permissions")]
        public List<string> Permissions { get; set; }

        /// <summary>
        /// List of data features that you would like to retrieve upon account creation.
        /// One of: <c>balances</c>, <c>ownership</c>, or <c>transactions</c>.
        /// </summary>
        [JsonProperty("prefetch")]
        [STJS.JsonPropertyName("prefetch")]
        public List<string> Prefetch { get; set; }
    }
}
